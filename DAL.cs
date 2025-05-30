using System;
using System.Data;
using System.Data.SqlClient;

namespace MovieApp
{
    /// <summary>
    /// Data Access Layer (DAL) for movie database operations
    /// Provides CRUD functionality for movie records with robust error handling
    /// </summary>
    internal class DAL
    {
        private readonly string connectionString;

        /// <summary>
        /// Initializes a new instance of the Data Access Layer
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public DAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Establishes and opens a database connection
        /// </summary>
        /// <returns>Open SqlConnection object</returns>
        /// <exception cref="DatabaseConnectionException">Thrown when connection fails</exception>
        private SqlConnection Connect()
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                // Wrap and rethrow with custom exception
                throw new DatabaseConnectionException("Database connection failed", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DatabaseConnectionException("Invalid connection operation", ex);
            }
        }

        /// <summary>
        /// Inserts a new movie record into the database
        /// </summary>
        /// <param name=title">Movie title</param>
        /// <param name="genre">Movie genre</param>
        /// <param name="price">Rental price</param>
        /// <exception cref="DataOperationException">Thrown when operation fails</exception>
        public void Insert(string title, string genre, float price)
        {
            string query = "INSERT INTO tblMovie(movieTitle,movieGenre,moviePrice) " +
                           "VALUES(@Title, @Genre, @Price);";

            try
            {
                using (var connection = Connect())
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Genre", genre);
                    command.Parameters.AddWithValue("@Price", price);

                    int rowsAffected = command.ExecuteNonQuery();

                    // Optional: Add debug logging here if needed
                    // Console.WriteLine($"Inserted {rowsAffected} row(s)");
                }
            }
            catch (SqlException ex)
            {
                throw new DataOperationException("Failed to insert movie record", ex);
            }
            catch (Exception ex)
            {
                throw new DataOperationException("Unexpected error during insert operation", ex);
            }
        }

        /// <summary>
        /// Updates an existing movie record
        /// </summary>
        /// <param name="id">Movie ID to update</param>
        /// <param name="title">Updated title</param>
        /// <param name="genre">Updated genre</param>
        /// <param name="price">Updated price</param>
        /// <exception cref="DataOperationException">Thrown when operation fails</exception>
        public void Update(int id, string title, string genre, float price)
        {
            string query = "UPDATE tblMovie SET movieTitle = @Title, " +
                           "movieGenre = @Genre, moviePrice = @Price " +
                           "WHERE movieID = @ID;";

            try
            {
                using (var connection = Connect())
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Genre", genre);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@ID", id);

                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new DataOperationException($"Failed to update movie ID {id}", ex);
            }
            catch (Exception ex)
            {
                throw new DataOperationException("Unexpected error during update operation", ex);
            }
        }

        /// <summary>
        /// Deletes a movie record by ID
        /// </summary>
        /// <param name="id">Movie ID to delete</param>
        /// <exception cref="DataOperationException">Thrown when operation fails</exception>
        public void Delete(int id)
        {
            string query = "DELETE FROM tblMovie WHERE movieID = @ID";

            try
            {
                using (var connection = Connect())
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new DataOperationException($"Failed to delete movie ID {id}", ex);
            }
            catch (Exception ex)
            {
                throw new DataOperationException("Unexpected error during delete operation", ex);
            }
        }

        /// <summary>
        /// Searches movies by title or genre
        /// </summary>
        /// <param name="search">Search term</param>
        /// <returns>DataTable containing matching records</returns>
        /// <exception cref="DataOperationException">Thrown when operation fails</exception>
        public DataTable SearchMovie(string search)
        {
            string query = "SELECT * FROM tblMovie " +
                            "WHERE movieTitle LIKE @Search OR movieGenre LIKE @Search";

            var dataTable = new DataTable();

            try
            {
                using (var connection = Connect())
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Search", "%" + search + "%");

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                return dataTable;
            }
            catch (SqlException ex)
            {
                throw new DataOperationException($"Search failed for term '{search}'", ex);
            }
            catch (Exception ex)
            {
                throw new DataOperationException("Unexpected error during search operation", ex);
            }
        }
    }

    /// <summary>
    /// Custom exception for database connection failures
    /// </summary>
    public class DatabaseConnectionException : Exception
    {
        public DatabaseConnectionException(string message, Exception inner)
            : base(message, inner) { }
    }

    /// <summary>
    /// Custom exception for data operations
    /// </summary>
    public class DataOperationException : Exception
    {
        public DataOperationException(string message, Exception inner)
            : base(message, inner) { }
    }
}