namespace ProcessingXML
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public class TraverseDirectoryXDocument
    {
        public static void Main()
        {
            // string fileName = "../../../DirTask9";          
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            XElement resultXmlXdocument = new XElement("main-element");

            resultXmlXdocument.Add(DirSearch("..\\..\\..\\DirTask9"));

            resultXmlXdocument.Save("../../../Task10resultXmlFromXdocument.xml");
            Console.WriteLine("The content of ..\\..\\..\\DirTask9 is extracted to file Task10ResultXmlXdocument.xml");
        }

        private static XElement DirSearch(string sDir)
        {
            XElement dir = new XElement("dir",
                new XAttribute("path", sDir));

            foreach (string f in Directory.GetFiles(sDir))
            {
                WriteFile(f, dir);
            }


            foreach (string d in Directory.GetDirectories(sDir))
            {
                dir.Add(DirSearch(d));                
            }

            return dir;
        }

        public static void WriteFile(string path, XElement dir)
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

            dir.Add(new XElement("file", content.ToString(), new XAttribute("path", path)));
        }
    }
}
