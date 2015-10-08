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
        const string ConnectionString= "Data Source=localhost; Integrated Security=SSPI; Initial Catalog=North";
        const string SQLCommandForCount = "SELECT COUNT(*) FROM Categories";
        const string CategoriesCount = "Categories count: {0} ";
        const string SQLCommandGetCategoryAndDescriptiom = "SELECT CategoryName, Description FROM Categories";
        const string SQLCommandCategoryProduct = "SELECT m.CategoryName, n.ProductName from Products n INNER JOIN Categories m on m.CategoryID = n.CategoryID ORDER BY m.CategoryID";
        const string FormatResult = "{0} - {1}";
        const string Task1 = "Task 1:";
        const string Task2 = "Task 2:";
        const string Task3 = "Task 3:";
        const string CategoryName = "CategoryName";
        const string Description = "Description";
        const string ProductName = "ProductName";
        static void Main()
        {
            SqlConnection dbCon =
                new SqlConnection(ConnectionString);
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
                  SQLCommandForCount, dbCon);
            int categoriesCount = (int)commandCategoriesCount.ExecuteScalar();
            Console.WriteLine(Task1);
            Console.WriteLine(CategoriesCount, categoriesCount);
            Console.WriteLine("");
        }

        private static void GetCategoriesNameAndDesription(SqlConnection dbCon)
        {
            SqlCommand commandCategoriesNameAndDescription = new SqlCommand(
               SQLCommandGetCategoryAndDescriptiom, dbCon);           
            SqlDataReader reader = commandCategoriesNameAndDescription.ExecuteReader();
            using (reader)
            {
                Console.WriteLine(Task2);
                while (reader.Read())
                {
                    string categoryName = (string)reader[CategoryName];
                    string description = (string)reader[Description];
                    Console.WriteLine(FormatResult, categoryName, description);
                }

                Console.WriteLine("");
            }        
        }

        private static void GetCategoriesAndProducts(SqlConnection dbCon)
        {
            SqlCommand commandCategoriesAndProducts = new SqlCommand(
                SQLCommandCategoryProduct, dbCon);
            SqlDataReader reader = commandCategoriesAndProducts.ExecuteReader();
            using (reader)
            {
                Console.WriteLine(Task3);
                while (reader.Read())
                {
                    string categoryName = (string)reader[CategoryName];
                    string productName = (string)reader[ProductName];
                    Console.WriteLine(FormatResult, categoryName, productName);
                }

                Console.WriteLine("");
            }
        }       
    }
}
