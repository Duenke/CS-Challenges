using System;
using System.Data.SQLite;
using System.IO;

namespace SQLiteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing SQLite database in C# ...");
            SQLiteConnection connection = CreateConnection();
            DropTables(connection);
            CreateTable(connection);
            InsertData(connection);
            ReadData(connection);
            connection.Close();

            Console.ReadKey();
        }

        private static void ReadData(SQLiteConnection connection)
        {
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "select * from Albums;";
            SQLiteDataReader dataReader = command.ExecuteReader();

            Console.WriteLine("\nReading data from Albums table:");
            while (dataReader.Read())
            {
                int col0 = dataReader.GetInt32(0);
                Console.Write($"{col0} ");
                string col1 = dataReader.GetString(1);
                Console.Write($"{col1} | ");
                string col2 = dataReader.GetString(2);
                Console.WriteLine(col2);
            }

            command = connection.CreateCommand();
            command.CommandText = "select * from Genres;";
            dataReader = command.ExecuteReader();

            Console.WriteLine("\nReading data from Genres table:");
            while (dataReader.Read())
            {
                int col0 = dataReader.GetInt32(0);
                Console.Write($"{col0} ");
                string col1 = dataReader.GetString(1);
                Console.WriteLine(col1);
            }
        }

        private static void InsertData(SQLiteConnection connection)
        {
            SQLiteCommand command = connection.CreateCommand();

            command.CommandText = "insert into Albums (col1, col2, col3) values(0, 'Album Name', 'Artist Name');";
            command.ExecuteNonQuery();

            command.CommandText = "insert into Albums (col1, col2, col3) values(1, 'Young at the Bend', 'Born Without Bones');";
            command.ExecuteNonQuery();

            command.CommandText = "insert into Albums (col1, col2, col3) values(2, 'Dealer', 'Foxing');";
            command.ExecuteNonQuery();

            command.CommandText = "insert into Albums (col1, col2, col3) values(3, 'Reach For The Sun', 'The Dangerous Summer');";
            command.ExecuteNonQuery();

            command.CommandText = "insert into Genres (col1, col2) values(0, 'Genre Type');";
            command.ExecuteNonQuery();

            command.CommandText = "insert into Genres (col1, col2) values(1, 'Indie');";
            command.ExecuteNonQuery();

            command.CommandText = "insert into Genres (col1, col2) values(2, 'Alternative');";
            command.ExecuteNonQuery();

            command.CommandText = "insert into Genres (col1, col2) values(3, 'Country');";
            command.ExecuteNonQuery();

            Console.WriteLine("Insert data into new tables...");
        }

        private static void CreateTable(SQLiteConnection connection)
        {
            SQLiteCommand command = connection.CreateCommand();
            string tableAlbums = "create table Albums (col1 int, col2 varchar(20), col3 varchar(20));";
            string tableGenres = "create table Genres (col1 int, col2 varchar(20));";

            command.CommandText = tableAlbums;
            command.ExecuteNonQuery();

            command.CommandText = tableGenres;
            command.ExecuteNonQuery();

            Console.WriteLine("Created new tables...");
        }

        private static void DropTables(SQLiteConnection connection)
        {
            SQLiteCommand command = connection.CreateCommand();
            string tableAlbums = "drop table if exists Albums";
            string tableGenres = "drop table if exists Genres";

            command.CommandText = tableAlbums;
            command.ExecuteNonQuery();

            command.CommandText = tableGenres;
            command.ExecuteNonQuery();

            Console.WriteLine("Dropped old tables...");
        }

        private static SQLiteConnection CreateConnection()
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source = database.db");
            
            if (!File.Exists("./database.db"))
            {
                SQLiteConnection.CreateFile("database.db");
                Console.WriteLine("Database file created...");
            }
            try
            {
                connection.Open();
                Console.WriteLine("SQLite connection created...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return connection;
        }
    }
}
