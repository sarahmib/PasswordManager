using Microsoft.Data.Sqlite;
using System

class Database
{
    SqliteConnection connection;
    public Database(string connectionString)
    {
        connection = new SqliteConnection(connectionString)
        connection.Open();
    }

    public
}