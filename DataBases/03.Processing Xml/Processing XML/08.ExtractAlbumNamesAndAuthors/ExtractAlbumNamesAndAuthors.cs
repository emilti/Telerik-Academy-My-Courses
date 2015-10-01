namespace ProcessingXML
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class ExtractAlbumNamesAndAuthors
    {
        public static void Main()
        {
            string fileName = "../../../album.xml";    
            Dictionary<string, string> albums = new Dictionary<string, string>();

            using (XmlReader reader = XmlReader.Create("../../../Catalogue.xml"))
            {
                var currentAlbumName = string.Empty;
                while (reader.Read())
                {
                    
                    if (reader.Name == "name")
                    {
                        // Console.WriteLine(reader.ReadElementString());
                        currentAlbumName = reader.ReadElementString();
                    }

                    if (reader.Name == "artist")
                    {
                        var currentArtist = reader.ReadElementString();
                        albums[currentAlbumName] = currentArtist;
                    }
                }
            }

            Encoding encoding = Encoding.GetEncoding("windows-1251");
            using (XmlTextWriter writer = new XmlTextWriter(fileName, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                writer.WriteStartDocument();
                writer.WriteStartElement("albums");
                foreach (var element in albums)
                {
                    WriteBook(writer, element.Key, element.Value);
                    Console.WriteLine("{0} - {1}", element.Key, element.Value);
                }

                writer.WriteEndElement();
                Console.WriteLine("Check the album.xml file in the main folder.");
            }   
        }

        public static void WriteBook(XmlWriter writer, string title, string author)
        {
            writer.WriteStartElement("album");
            writer.WriteElementString("name", title);
            writer.WriteElementString("author", author);            
            writer.WriteEndElement();
        }
    }
}
