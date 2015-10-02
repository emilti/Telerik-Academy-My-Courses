namespace ProcessingJson
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class DownloadContent
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var webClient = new WebClient();

            // Task 2 Download data
            var data = webClient.DownloadData("https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw");

            // Task 3 Parse the XML to JSON
            var xmlContent = Encoding.UTF8.GetString(data);
            var doc = new XmlDocument();
            doc.LoadXml(xmlContent);
            var jsonContent = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);
            
            // File.WriteAllText("../../../RSSfeed.json", jsonContent);
            // Console.WriteLine(jsonContent);      

            // Task 4 Using LINQ-to-JSON select all the video titles and print the on the console
            JObject rss = JObject.Parse(jsonContent);
            var videoTtles =
            from p in rss["feed"]["entry"]
            select (string)p["title"];
            foreach (var videoTitle in videoTtles)
            {
                Console.WriteLine(videoTitle);
            }
        }
    }
}
