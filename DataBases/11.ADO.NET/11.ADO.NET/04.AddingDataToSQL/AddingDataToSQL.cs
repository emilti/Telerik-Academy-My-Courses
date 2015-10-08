namespace Adonet
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class AddingDataToSQL
    {
        const string ConnectionString = "Data Source=localhost; Integrated Security=SSPI; Initial Catalog=North";
        const string SQLInsertCommand = "INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued ) " +
           "VALUES (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued)";
        public static void Main()
        {
            SqlConnection dbCon =
               new SqlConnection(ConnectionString);
            dbCon.Open();
            using (dbCon)
            {
                AddRowToProducts("MyProduct", 3, 2, 10, 99, 1, 1, 3, 0, dbCon);
            }
        }

        public static void AddRowToProducts(string productName, int supplierID, 
            int categoryID, int quantityPerUnit, 
            int unitPrice, int  unitsInStock,   
            int unitsOnOrder, int reorderLevel,
            int discontinued, SqlConnection dbCon)
        {
            SqlCommand commandInsertRow = new SqlCommand(SQLInsertCommand, dbCon);
            commandInsertRow.Parameters.AddWithValue("@ProductName", productName);
            commandInsertRow.Parameters.AddWithValue("@SupplierID", supplierID);
            commandInsertRow.Parameters.AddWithValue("@CategoryID", categoryID);
            commandInsertRow.Parameters.AddWithValue("@QuantityPerUnit", quantityPerUnit);
            commandInsertRow.Parameters.AddWithValue("@UnitPrice", unitPrice);
            commandInsertRow.Parameters.AddWithValue("@UnitsInStock", unitsInStock);
            commandInsertRow.Parameters.AddWithValue("@UnitsOnOrder", unitsOnOrder);
            commandInsertRow.Parameters.AddWithValue("@ReorderLevel", reorderLevel);
            commandInsertRow.Parameters.AddWithValue("@Discontinued", discontinued);
            commandInsertRow.ExecuteNonQuery();
        }
          
    }
}
