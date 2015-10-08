namespace Adonet
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RetrieveDataFromSQL
    {
        static void Main()
        {
            SqlConnection dbCon = 
                new SqlConnection("Data Source=localhost; Integrated Security=SSPI;" +
                                            "Initial Catalog=North");
            dbCon.Open();
            using (dbCon)
            {
                GetCategoriesCount(dbCon);
                GetCategoriesNameAndDesription(dbCon);
                GetCategoriesAndProducts(dbCon);
            }
        }

        private static void GetCategoriesCount(SqlConnection dbCon)
        {
            SqlCommand commandCategoriesCount = new SqlCommand(
                  "SELECT COUNT(*) FROM Categories", dbCon);
            int categoriesCount = (int)commandCategoriesCount.ExecuteScalar();
            Console.WriteLine("Task 1:");
            Console.WriteLine("Categories count: {0} ", categoriesCount);
            Console.WriteLine("");
        }

        private static void GetCategoriesNameAndDesription(SqlConnection dbCon)
        {
            SqlCommand commandCategoriesNameAndDescription = new SqlCommand(
                "SELECT CategoryName, Description FROM Categories", dbCon);           
            SqlDataReader reader = commandCategoriesNameAndDescription.ExecuteReader();
            using (reader)
            {
                Console.WriteLine("Task 2:");
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];
                    Console.WriteLine("{0} - {1}", categoryName, description);
                }

                Console.WriteLine("");
            }        
        }

        private static void GetCategoriesAndProducts(SqlConnection dbCon)
        {
            SqlCommand commandCategoriesAndProducts = new SqlCommand(
                "SELECT m.CategoryName, n.ProductName " +
                "from Products n " +
                "INNER JOIN Categories m " +
                "on m.CategoryID = n.CategoryID "+
                "ORDER BY m.CategoryID", dbCon);
            SqlDataReader reader = commandCategoriesAndProducts.ExecuteReader();
            using (reader)
            {
                Console.WriteLine("Task 3:");
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string productName = (string)reader["ProductName"];
                    Console.WriteLine("{0} - {1}", categoryName, productName);
                }

                Console.WriteLine("");
            }
        }       
    }
}
