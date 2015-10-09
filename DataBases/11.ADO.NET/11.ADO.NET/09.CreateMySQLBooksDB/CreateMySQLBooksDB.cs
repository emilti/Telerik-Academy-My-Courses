namespace Adonet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MySql.Data.MySqlClient;

    public class CreateMySQLBooksDB
    {
        public const string AddBookSQLCommand = @"INSERT INTO Books (Title, Author, PublishDate, ISBN) VALUES (@title, @author, @publishDate, @isbn)";
        public const string ListAllBookSQLCommand = @"SELECT id, Title, Author, PublishDate, ISBN FROM Books";
        public const string SearchForBookByTitleSQLCommand = @"SELECT id, Title, Author, PublishDate, ISBN FROM Books WHERE Title = @title";

        public static void Main()
        {
            string password = EnterPassword();
            string connectionString;
            MySqlConnection connection;
            InitializeConnection(password, out connectionString, out connection);
            
            MySqlCommand command = CreateDatabase(connection);           
            MySqlConnection connectionDB = new MySqlConnection(connectionString + "Database=Books;");            
            connectionDB.Open();            
            command = CreateBooksTable(command, connectionDB);

            // command = InsertBooks(connectionDB);
            bool isInLibrary = true;
            while (isInLibrary)
            {
                Console.WriteLine("Choose option:");
                Console.WriteLine("1 ---> Add book to the database");
                Console.WriteLine("2 ---> Search for book in the database");
                Console.WriteLine("3 ---> List the books from the database");
                Console.WriteLine("Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1": command = AddBook(connectionDB);
                        break;
                    case "2": command = SearchForBookByTitle(connectionDB);
                        break;
                    case "3": command = ListBooks(connectionDB);
                        break;
                    case "Exit": isInLibrary = false;
                        break;
                    default: Console.WriteLine("\nInvalid input\n");
                        break;
                }              
            }
          
            connectionDB.Close();
        }

        private static MySqlCommand SearchForBookByTitle(MySqlConnection connectionDB)
        {
            Console.WriteLine("Search By Title:");
            string searchedTitle = Console.ReadLine();
            MySqlCommand command = new MySqlCommand(SearchForBookByTitleSQLCommand, connectionDB);
            command.Parameters.AddWithValue("@title", searchedTitle);
            MySqlDataReader rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2] + " -- " + rdr[3] + " -- " + rdr[4]);
            }

            rdr.Close();
            command.Parameters.Clear();
 
            return command;
        }

        private static MySqlCommand AddBook(MySqlConnection connectionDB)
        {
            Console.Write("Title:");
            string title = Console.ReadLine();
            Console.Write("author:");
            string author = Console.ReadLine();
            Console.Write("publishDate:");
            DateTime publishDate = DateTime.Parse(Console.ReadLine());
            Console.Write("ISBN:");
            int isbn = int.Parse(Console.ReadLine());

            MySqlCommand command = new MySqlCommand(AddBookSQLCommand, connectionDB);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@publishDate", publishDate);
            command.Parameters.AddWithValue("@isbn", isbn);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            return command;
        }

        private static MySqlCommand InsertBooks(MySqlConnection connectionDB)
        {
            MySqlCommand command = new MySqlCommand(AddBookSQLCommand, connectionDB);
            for (int i = 0; i < 10; i++)
            {
                command.Parameters.AddWithValue("@title", "title" + i);
                command.Parameters.AddWithValue("@author", "author" + i);
                command.Parameters.AddWithValue("@publishDate", "2000/10/10");
                command.Parameters.AddWithValue("@isbn", 1000 + i);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }

            return command;
        }

        private static MySqlCommand ListBooks(MySqlConnection connectionDB)
        {
            MySqlCommand command = new MySqlCommand(ListAllBookSQLCommand, connectionDB);

            MySqlDataReader rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2] + " -- " + rdr[3] + " -- " + rdr[4]);
            }

            rdr.Close();
            command.Parameters.Clear();
            return command;
        }

        private static MySqlCommand CreateBooksTable(MySqlCommand command, MySqlConnection connectionDB)
        {
            string createSchema = // "use `Books`" +
             "CREATE TABLE IF NOT EXISTS Books " +
             "(id int AUTO_INCREMENT," +
             "title  nvarchar(50)," +
              "author nvarchar(50)," +
              "publishDate date," +
              "ISBN  int," +
               "PRIMARY KEY (id)" +
              ") ";

            command = new MySqlCommand(createSchema, connectionDB);
            command.ExecuteNonQuery();
            return command;
        }

        private static MySqlCommand CreateDatabase(MySqlConnection connection)
        {
            MySqlCommand command;
            string createDatabase;
            connection.Open();
            createDatabase = "CREATE DATABASE IF NOT EXISTS `Books`;";
            command = new MySqlCommand(createDatabase, connection);
            command.ExecuteNonQuery();
            connection.Close();
            return command;
        }

        private static void InitializeConnection(string password, out string connectionString, out MySqlConnection connection)
        {
            connectionString = string.Format("server=localhost;user=root;port=3306;password={0};", password);
            connection = new MySqlConnection(connectionString);
        }

        private static string EnterPassword()
        {
            Console.WriteLine("Enter password for MySQL server:");
            string password = Console.ReadLine();
            return password;
        }
    }
}
