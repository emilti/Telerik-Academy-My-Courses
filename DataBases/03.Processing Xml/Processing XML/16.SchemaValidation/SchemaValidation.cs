using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ProcessingXML
{
    public class SchemaValidation
    {
        public static void Main()
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", "../../Catalogue.xsd");
            XDocument xmlValidDoc = XDocument.Load("../../Catalogue.xml");
            XDocument xmlInvalidDoc = XDocument.Load("../../CatalogueInvalid.xml");
            bool errors = false;

            Console.WriteLine("Validating xmlValidDoc");
            xmlValidDoc.Validate(schemas, (o, e) =>
                     {
                         Console.WriteLine("{0}", e.Message);
                         errors = true;
                     });
            Console.WriteLine("doc1 {0}", errors ? "did not validate" : "validated");

            Console.WriteLine();
            Console.WriteLine("Validating xmlInvalidDoc");
            errors = false;
            xmlInvalidDoc.Validate(schemas, (o, e) =>
                                 {
                                     Console.WriteLine("{0}", e.Message);
                                     errors = true;
                                 });
            Console.WriteLine("doc2 {0}", errors ? "did not validate" : "validated");


        }
    }
}
