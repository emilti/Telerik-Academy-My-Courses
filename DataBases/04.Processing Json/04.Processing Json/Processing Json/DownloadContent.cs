namespace ProcessingJson
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DownloadContent
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var webClient = new WebClient();

            // Task 2 Download data
            var data = DownloadRSS(webClient);

            // Task 3 Parse the XML to JSON
            var xmlContent = Encoding.UTF8.GetString(data);
            var doc = new XmlDocument();
            var jsonContent = ParseXMLToJSON(xmlContent, doc);              

            // Task 4 Using LINQ-to-JSON select all the video titles and print the on the console
            JObject rssJSON = JObject.Parse(jsonContent);
            PrintTitles(rssJSON);

            // Task 5 Parse JSON to 
            var videos = GetAllVideosFromJSON(rssJSON.ToString());

            // Task 6 Generate HTML
            var html = GenerateHtml(videos);
            File.WriteAllText("../../videos.html", html.ToString(), Encoding.UTF8);            
        }

        private static object GenerateHtml(IEnumerable<Video> videos)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html><title>Telerik Videos From RSS</title><body>");
            foreach (var video in videos)
            {
                sb.AppendFormat("<h1><a href='{0}'>" + video.Title + "</a></h1>", video.Link.Href);                
                sb.AppendFormat("<iframe id='player' type='text/html' width='640' height='390'src='http://www.youtube.com/embed/{0}?autoplay=1' frameborder='0'></iframe>", video.Id);             
                sb.Append("</iframe>"); 
            }

            sb.Append("</body></html>");
            return sb.ToString();
        }

        private static string ParseXMLToJSON(string xmlContent, XmlDocument doc)
        {
            doc.LoadXml(xmlContent);
            var jsonContent = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText("../../../RSSfeed.json", jsonContent);
            return jsonContent;
        }

        private static byte[] DownloadRSS(WebClient webClient)
        {
            var data = webClient.DownloadData("https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw");
            return data;
        }

        private static void PrintTitles(JObject rss)
        {
            var videoTitles =
            from p in rss["feed"]["entry"]
            select p["title"];

            foreach (var videoTitle in videoTitles)
            {
                Console.WriteLine(videoTitle);
            }
        }

        private static IEnumerable<Video> GetAllVideosFromJSON(string rssJSONFeed)
        {
            var jsonRSSObj = JObject.Parse(rssJSONFeed);
            var extractedVideos = jsonRSSObj["feed"]["entry"].Select(v => JsonConvert.DeserializeObject<Video>(v.ToString()));

            return extractedVideos;
        }
    }
}
