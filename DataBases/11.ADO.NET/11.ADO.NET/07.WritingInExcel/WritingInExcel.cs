namespace Adonet
{
    using System;
    using System.Collections.Generic;
    using System.Data.OleDb;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class WritingInExcel
    {
        public static void Main()
        {
            string importFileName = "../../Data.xlsx";
            System.Data.OleDb.OleDbConnection myConnection;           
            myConnection = new System.Data.OleDb.OleDbConnection(
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + importFileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=3;READONLY=FALSE'");
            using (myConnection)
            {
                myConnection.Open();
                var sheetName = GetSheetName(myConnection);
                var cmd = GetCommand(myConnection, sheetName);             
                var queryResult = cmd.ExecuteNonQuery();
                myConnection.Close();
            }
        }

        private static OleDbCommand GetCommand(OleDbConnection oleDbConnection, string sheetName)
        {
            const string Name = "Pesho";
            const int Score = 20;
            var cmd =
                new OleDbCommand("INSERT INTO [" + sheetName + "] VALUES (@name, @score)", oleDbConnection);

            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@score", Score);

            return cmd;
        }

        private static string GetSheetName(OleDbConnection oleDbConnection)
        {
            var excelSchema = oleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            var dataTable = excelSchema.Rows[0]["TABLE_NAME"].ToString();
            return dataTable;
        }
    }
}
