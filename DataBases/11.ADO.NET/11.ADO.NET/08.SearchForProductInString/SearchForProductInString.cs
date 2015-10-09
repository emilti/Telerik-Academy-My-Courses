namespace Adonet
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class SearchForProductInString
    {
        private const string ConnectionString = "Data Source=localhost; Integrated Security=SSPI; Initial Catalog=North";
        private const string SQLCommandForGettingProducts = "SELECT ProductName FROM Products WHERE ProductName LIKE '%'+@input+'%' ESCAPE '!'";
        private const string Task8 = "Task 8:";

        public static void Main()
        {
            string input = ReadInputString();
            string formattedString = FormatString(input);
            SqlConnection dbCon =
               new SqlConnection(ConnectionString);
            dbCon.Open();
            using (dbCon)
            {
                GetProducts(dbCon, formattedString);                
            }
        }

        private static string FormatString(string input)
        {
            string formattedString = input;         
            for (int i = 0; i < formattedString.Length; i++)
            {
                if (formattedString[i] == '%' || 
                    formattedString[i] == '_' ||
                    formattedString[i] == '\'' ||
                    formattedString[i] == '\\' ||
                    formattedString[i] == '"')
                {
                    formattedString = input.Substring(0, i) + "!" + input.Substring(i, input.Length - i);
                }
            }

            return formattedString;
        }

        private static string ReadInputString()
        {
            Console.WriteLine("Enter string:");
            string input = Console.ReadLine();
            return input;
        }

        private static void GetProducts(SqlConnection dbCon, string input)
        {
            SqlCommand commandForGettingProducts = new SqlCommand(
                  SQLCommandForGettingProducts, dbCon);
            commandForGettingProducts.Parameters.AddWithValue("@input", input);
            var reader = commandForGettingProducts.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["ProductName"]);
            }
        }
    }
}
