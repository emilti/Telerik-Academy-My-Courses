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
        public static void Main()
        {
            string connectionString = "server=localhost;user=root;port=3306;password=baramundi123;database=Books";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command;
            string createDatabase;

            try
            {
                connection.Open();
                createDatabase = "CREATE DATABASE IF NOT EXISTS `Books`;";
                command = new MySqlCommand(createDatabase, connection);
                command.ExecuteNonQuery();

                string createSchema = // "USE `Books`" +
                 "CREATE TABLE IF NOT EXISTS Books " +
                 "(id int," +
                 "title  nvarchar(50)," +
                  "author nvarchar(50)," +
                  "publishDate date," +
                  "ISBN  int" +
                  ") ";               
               
                command = new MySqlCommand(createSchema, connection);
                command.ExecuteNonQuery();

                string insertSQL = "INSERT INTO Books VALUES(@id, @title, @author, @publishDate, @ISBN)";
                command = new MySqlCommand(insertSQL, connection);
                //for (int i = 0; i < 10; i++)
                //{
                int i = 1;
                    command.Parameters.AddWithValue("@id", i);
                    command.Parameters.AddWithValue("@title", "title" + i);
                    command.Parameters.AddWithValue("@author", "author" + i);
                    command.Parameters.AddWithValue("@publishDate", "10/10/2000");
                    command.Parameters.AddWithValue("@title",  1000 + i);
                    command.ExecuteNonQuery();
                //}
               
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
