namespace ProcessingXML
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Linq;
    

    public class ExtractPricesForAlbumsFromEarlierThan5yLINQ
    {
        public static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../../Catalogue.xml");            
            // from title in xmlDoc.Descendants("title")
           //  select (string)title;


            var prices =
            from x in xmlDoc.Descendants("album")
            where int.Parse(x.Element("year-of-release").Value) > 2010
            select x.Element("price");

            foreach (var price in prices)
            {
                Console.WriteLine("price:" + price.Value);
            }
        }
    }
}
