using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace MovieApp
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MovieAppDB;Integrated Security=True";


        public Form1()
        {
            InitializeComponent();
            LoadMovies();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadMovies()
        {
            try
            {
                string query = "SELECT * FROM tblMovie;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    dataGridView2.Rows.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        dataGridView2.Rows.Add(row["movieID"], row["movieTitle"], row["movieGenre"], row["moviePrice"]);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading movies: {ex.Message}",
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs

                string title = inTitle.Text;
                string genre = inGenre.Text;
                Boolean validPrice = float.TryParse(inPrice.Text, out float price);

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(genre))
                {
                    MessageBox.Show("All fields must be filled", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!validPrice)
                {
                    //               Message                          Box Title              for button             for error Icon   
                    MessageBox.Show("Input correct format for price", "Invalid Price Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                DAL dal = new DAL(connectionString);

                dal.Insert(title, genre, price);

                inTitle.Text = null;
                inGenre.Text = null;
                inPrice.Text = null;
                LoadMovies();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting movie: {ex.Message}",
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private int index;
        private string id = "";

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[index];
            id = row.Cells[0].Value.ToString();
            inTitle.Text = row.Cells[1].Value.ToString();
            inGenre.Text = row.Cells[2].Value.ToString();
            inPrice.Text = row.Cells[3].Value.ToString();
            // MessageBox.Show("The index value: " + index);

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please select the row to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            string Title = inTitle.Text;
            string Genre = inGenre.Text;
            float Price = float.Parse(inPrice.Text);

            int mID = int.Parse(id);

            try
            {
                DAL dal = new DAL(connectionString);
                dal.Update(mID, Title, Genre, Price);

                LoadMovies();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating movie: {ex.Message}",
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            inTitle.Text = null;
            inGenre.Text = null;
            inPrice.Text = null;
            id = "";
            LoadMovies();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please select the row to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int movieID = int.Parse(id);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this movie?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DAL dal = new DAL(connectionString);

                try
                {
                    dal.Delete(movieID);
                    LoadMovies();
                }
                catch (DataOperationException ex)
                {
                    MessageBox.Show($"Error while deleting movie: {ex.Message}",
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
            }

        }

        private void searchBar_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;

            if (string.IsNullOrEmpty(search) || string.IsNullOrWhiteSpace(search))
            {
                MessageBox.Show("Please enter Title or Genre to search", "Search Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DAL dal = new DAL(connectionString);

            DataTable dataTable = dal.SearchMovie(search);

            if (dataTable.Rows.Count > 0)
            {
                dataGridView2.Rows.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridView2.Rows.Add(row["movieID"], row["movieTitle"], row["movieGenre"], row["moviePrice"]);
                }


            }
            else
            {
                MessageBox.Show("No movie found matching your search", "Best Movie.net", MessageBoxButtons.OK);

            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
