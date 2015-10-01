namespace ProcessingXML
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class ExtractAllSongsWithXmlReader
    {
        public static void Main()
        {
            using (XmlReader reader = XmlReader.Create("../../../Catalogue.xml"))
            {
                while (reader.Read()) 
                {
                    if (reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
