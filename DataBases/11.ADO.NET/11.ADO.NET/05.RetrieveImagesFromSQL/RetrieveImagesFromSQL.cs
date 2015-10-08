namespace Adonet
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RetrieveImagesFromSQL
    {
        public const string ConnectionString = "Data Source=localhost; Integrated Security=SSPI; Initial Catalog=North";
        static void Main()
        {   

            SqlConnection dbConn = new SqlConnection(
           ConnectionString);
            dbConn.Open();
            using (dbConn)
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT Image, ImageFormat FROM Images " +
                    "WHERE ImageId=@id", dbConn);
                SqlParameter paramId = new SqlParameter(
                    "@id", SqlDbType.Int);
                paramId.Value = imageId;
                cmd.Parameters.Add(paramId);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    if (reader.Read())
                    {
                        image = (byte[])reader["Image"];
                        imageFormat = (string)reader["ImageFormat"];
                    }
                    else
                    {
                        throw new Exception(
                            String.Format("Invalid image ID={0}.", imageId));
                    }
                }
            }
        }
    }
}
