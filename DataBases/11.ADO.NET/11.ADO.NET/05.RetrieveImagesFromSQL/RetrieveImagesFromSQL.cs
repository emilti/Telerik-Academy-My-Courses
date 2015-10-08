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
        const string ConnectionString = "Data Source=localhost; Integrated Security=SSPI; Initial Catalog=North";
        const string SQLExtractPictureData = "SELECT Picture FROM Categories";
        const string FileExtension = ".jpg";
        const string Picture = "Picture";
        static void Main()
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
            const int oleMetaPictStartPosition = 78;
            var memoryStream =
                new MemoryStream(imageFromDB, oleMetaPictStartPosition,
                    imageFromDB.Length - oleMetaPictStartPosition);
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
