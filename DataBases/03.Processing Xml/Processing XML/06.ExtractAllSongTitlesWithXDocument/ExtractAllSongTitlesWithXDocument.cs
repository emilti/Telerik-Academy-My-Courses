namespace ProcessingXml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public class ExtractAllSongTitlesWithXDocument
    {
        public static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../../Catalogue.xml");
            var titles =
             from title in xmlDoc.Descendants("title")
             select (string)title;

            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
