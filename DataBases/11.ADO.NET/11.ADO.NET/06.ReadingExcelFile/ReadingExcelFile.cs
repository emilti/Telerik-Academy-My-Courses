namespace Adonet
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;  

    public class ReadingExcelFile
    {
        public static void Main()
        {
            string importFileName = "../../Data.xlsx";
            System.Data.OleDb.OleDbConnection myConnection;
            System.Data.DataSet dtSet;
            System.Data.OleDb.OleDbDataAdapter myCommand;
            myConnection = new System.Data.OleDb.OleDbConnection(
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + importFileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=3;READONLY=FALSE'");
            myCommand = new System.Data.OleDb.OleDbDataAdapter(
                "select * from [Sheet1$]", myConnection);
            myCommand.TableMappings.Add("Table", "TestTable");
            dtSet = new System.Data.DataSet();
            myCommand.Fill(dtSet);
            for (int i = 0; i < dtSet.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < dtSet.Tables[0].Columns.Count; j++)
                {
                    Console.Write(dtSet.Tables[0].Rows[i][j].ToString() + ' ');          
                }

                Console.WriteLine();               
            }          

            string commandString = string.Format("INSERT INTO [{0}${1}{2}:{1}{2}] SET F1='{3}'", "Sheet1", "A", "6", "bbb");
            OleDbCommand commande = new OleDbCommand(
                commandString, myConnection);       
            myConnection.Close();            
        }       
    }
}