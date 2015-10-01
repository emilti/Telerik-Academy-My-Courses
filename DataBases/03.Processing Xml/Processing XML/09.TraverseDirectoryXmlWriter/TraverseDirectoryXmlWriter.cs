namespace ProcessingXML
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class TraverseDirectoryXmlWriter
    {
        public static void Main()
        {
            // string fileName = "../../../DirTask9";
            string resultXml = "..\\..\\..\\Task9ResultXml.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            XmlTextWriter writer = new XmlTextWriter(resultXml, encoding);
            using (writer)
            {
                writer.WriteStartDocument();
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;              
                DirSearch("..\\..\\..\\DirTask9", writer);
            }

            Console.WriteLine("The content of ..\\..\\..\\DirTask9 is extracted to file Task9ResultXml.xml");
        }


        private static void DirSearch(string sDir, XmlWriter writer)
        {
            writer.WriteStartElement("dir");
            writer.WriteAttributeString("path", sDir); 
            foreach (string f in Directory.GetFiles(sDir))
            { 
                WriteFile(writer, f);               
            }

            foreach (string d in Directory.GetDirectories(sDir))
            {
                DirSearch(d, writer);
                writer.WriteEndElement();
            }          
        }

        public static void WriteFile(XmlWriter writer, string path)
        {
            StringBuilder content = new StringBuilder();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    content.AppendLine(line); // Add to list.                                   
                }
            }

            writer.WriteStartElement("file");
            writer.WriteAttributeString("path", path);   
            writer.WriteString( content.ToString());                      
            writer.WriteEndElement();
        }
    }
}
