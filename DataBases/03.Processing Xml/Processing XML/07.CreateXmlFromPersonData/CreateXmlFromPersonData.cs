namespace ProcessingXML
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public class CreateXmlFromPersonData
    {
        public static void Main()
        {
            List<string> personData = new List<string>();
            using (StreamReader reader = new StreamReader("../../../PersonData.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    personData.Add(line); // Add to list.
                    Console.WriteLine(line); // Write to console.                    
                }
            }

            XElement personXml = new XElement("persons",
            new XElement("person",
                new XElement("name", personData[0]),
                new XElement("address", personData[1]),
                new XElement("phone", personData[2])
                )

        );
            personXml.Save("../../../person.xml");
            Console.WriteLine("Check the file Person.Xml in the main folder ProcessingXml with the projects .");
        }
    }
}
