# MovieApp - Windows Forms Application

![C#](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?logo=microsoft-sql-server&logoColor=white)

A Windows Forms application for managing movie databases, developed for Development Software(DS) 2 activities.

## Features
- 🎬 CRUD operations for movie records
- 🔍 Search movies by title/genre
- 📊 DataGridView display with selection
- ✅ Input validation and error handling
- 🗑️ Safe delete with confirmation dialogs

## Technologies
- C# (.NET Framework)
- Windows Forms
- SQL Server LocalDB
- ADO.NET for data access
- Git for version control

## Database Schema
```sql
CREATE TABLE tblMovie (
    movieID INT IDENTITY(1,1) PRIMARY KEY,
    movieTitle NVARCHAR(100) NOT NULL,
    movieGenre NVARCHAR(50) NOT NULL,
    moviePrice FLOAT NOT NULL
);