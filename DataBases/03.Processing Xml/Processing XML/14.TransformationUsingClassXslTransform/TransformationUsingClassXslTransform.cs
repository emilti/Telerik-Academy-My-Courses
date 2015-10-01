namespace ProcessingXML
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Xsl;

    public class TransformationUsingClassXslTransform
    {
        public static void Main()
        {
             XslCompiledTransform xslt = new XslCompiledTransform();
             xslt.Load("../../../CatalogueStyles.xslt");
             xslt.Transform("../../../Catalogue.xml", "../../../Task14Catalog.html");
        }
    }
}
