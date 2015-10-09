namespace Adonet
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RetrieveImagesFromSQL
    {
        private const string ConnectionString = "Data Source=localhost; Integrated Security=SSPI; Initial Catalog=North";
        private const string SQLExtractPictureData = "SELECT Picture FROM Categories";
        private const string FileExtension = ".jpg";
        private const string Picture = "Picture";

        public static void Main()
        {
            SqlConnection dbConn = new SqlConnection(
            ConnectionString);
            dbConn.Open();
            using (dbConn)
            {
                MemoryStream stream = new MemoryStream();
                SqlCommand cmd = new SqlCommand(SQLExtractPictureData, dbConn);              
                SqlDataReader reader = cmd.ExecuteReader();
                byte[] imageFromDB;     
                string filename = string.Empty;
                using (reader)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        i++;
                        string finalFilename = filename + i;
                        imageFromDB = (byte[])reader[Picture];
                        SaveImageToJPG(imageFromDB, finalFilename);                       
                    }
                }
            }
        }

        private static void SaveImageToJPG(byte[] imageFromDB, string filename)
        {
            const int OleMetaPictStartPosition = 78;
            var memoryStream =
                new MemoryStream(
                    imageFromDB, 
                    OleMetaPictStartPosition,
                    imageFromDB.Length - OleMetaPictStartPosition);
            using (memoryStream)
            {
                using (var image = Image.FromStream(memoryStream, true, true))
                {
                    image.Save(filename + FileExtension);
                }
            }
        }
    }
}
