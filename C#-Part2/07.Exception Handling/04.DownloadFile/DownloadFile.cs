using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

public class DownloadFile
{
    public static void Main()
    {
        try
        {
            using (WebClient client = new WebClient())
            {
                Console.WriteLine("Enter the path of the file and the name of the file that will be downloaded in \" ");
                string path = Console.ReadLine();
                Console.Write("Enter the file name with extension:");
                string fileName = Console.ReadLine();
                Console.WriteLine("Example downloading ninja.jpg.");
                client.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "ninja.png");

                // Client.DownloadFile(path, fileName);
                // The file is in debug folder
                Console.WriteLine(@"The file ""ninja.jpg"" is in the debug folder");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught!\n{0} - {1}", ex.GetType().Name, ex.Message); 
        }
    }
}