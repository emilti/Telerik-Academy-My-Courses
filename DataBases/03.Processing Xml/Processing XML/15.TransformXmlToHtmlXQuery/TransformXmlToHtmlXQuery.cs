namespace ProcessingXML
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TransformXmlToHtmlXQuery
    {
        public static void Main()
        {
            using Saxon.Api;

var xslt = new FileInfo(@"C:\path\to\stylesheet.xslt");
var input = new FileInfo(@"C:\path\to\data.xml");
var output = new FileInfo(@"C:\path\to\result.xml");

// Compile stylesheet
var processor = new Processor();
var compiler = processor.NewXsltCompiler();
var executable = compiler.Compile(new Uri(xslt.FullName));

// Do transformation to a destination
var destination = new DomDestination();
using(var inputStream = input.OpenRead())
{
    var transformer = executable.Load();
    transformer.SetInputStream(inputStream, new Uri(input.DirectoryName));
    transformer.Run(destination);
}

// Save result to a file (or whatever else you wanna do)
destination.XmlDocument.Save(output.FullName);
        }
    }
}
