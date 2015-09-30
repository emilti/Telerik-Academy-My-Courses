namespace ProcessingXML
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class ExtractingArtistsWithXpath
    {
        public static void Main()
        {
            Hashtable artists = new Hashtable();
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../Catalogue.xml");
            XmlNode rootNode = doc.DocumentElement;
            string xPathQuery = "/catalogue/album/artist";

            XmlNodeList artistsList =
              doc.SelectNodes(xPathQuery);
            
            foreach (XmlNode artist in artistsList)
            {
                if (artists.ContainsKey(artist.InnerText))
                {
                    artists[artist.InnerText] = (int)artists[artist.InnerText] + 1;
                }

                else
                {
                    artists[artist.InnerText] = 1;
                }
            }

            foreach (var artist in artists.Keys)
            {
                Console.WriteLine("Artist: {0}| Number of Albums in the catalogue: {1}", artist, artists[artist]);
            }
        }
    }
}
