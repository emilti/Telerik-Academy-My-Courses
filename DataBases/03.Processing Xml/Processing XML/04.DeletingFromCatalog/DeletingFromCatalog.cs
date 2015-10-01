namespace ProcessingXML
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class DeletingFromCatalog
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../Catalogue.xml");
            XmlNode rootNode = doc.DocumentElement;
            var nodesToRemove = new List<XmlNode>();

            foreach (XmlNode album in rootNode.ChildNodes)
            {
                Console.WriteLine(album["price"].InnerText);
                 if (int.Parse(album["price"].InnerText) < 20)
                 {
                     nodesToRemove.Add(album);
                     Console.WriteLine(album);
                 }
            }

            foreach (XmlNode album in nodesToRemove)
            {
                rootNode.RemoveChild(album);
            }

            doc.Save("../../../" + "Task4CatalogueWithdeletedAlbums.xml");
        }
    }
}
