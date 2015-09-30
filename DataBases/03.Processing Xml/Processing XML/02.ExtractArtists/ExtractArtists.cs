//2. Write program that extracts all different artists which are found in the catalog.xml.
// 
//     For each author you should print the number of albums in the catalogue.
//     Use the DOM parser and a hash-table.

namespace ProcessingXML
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class ExtractArtists
    {
        static void Main()
        {
            Hashtable artists = new Hashtable();
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../Catalogue.xml");
            XmlNode rootNode = doc.DocumentElement;
            Console.WriteLine("Root node: {0}", rootNode.Name);
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if (childNode.Name == "artist")
                    {
                        if (artists.ContainsKey(childNode.InnerText))
                        {
                            artists[childNode.InnerText] = (int)artists[childNode.InnerText] + 1;
                        }

                        else
                        {
                            artists[childNode.InnerText] = 1;
                        }
                    }
                }
            }

            foreach (var artist in artists.Keys)
            {
                Console.WriteLine("Artist: {0}| Number of Albums in the catalogue: {1}",artist, artists[artist]);
            }
        }
    }
}
