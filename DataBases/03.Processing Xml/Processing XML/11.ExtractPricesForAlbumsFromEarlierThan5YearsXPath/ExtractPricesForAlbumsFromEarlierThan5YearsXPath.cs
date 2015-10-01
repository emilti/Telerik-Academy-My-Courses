namespace ProcessingXML
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class ExtractPricesForAlbumsFromEarlierThan5YearsXPath
    {
        public static void Main()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../Catalogue.xml");
            string datesQuery = "/catalogue/album/year-of-release/text()";
            XmlNodeList dates = xmlDoc.SelectNodes(datesQuery);

            foreach (XmlNode date in dates)
            {
                string year = date.InnerText;
                if (int.Parse(year) >= 2010)
                {                                      
                    XmlNode album = date.ParentNode.ParentNode;
                    XmlNode albumName = album.SelectSingleNode("name"); 
                    XmlNode albumPrice = album.SelectSingleNode("price");
                    Console.WriteLine("{0} - {1}", albumName.InnerText, albumPrice.InnerText);
                }               
            }
        }
    }
}
