namespace ProcessingJson
{    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Xsl;
    using Newtonsoft.Json;

    public class Video
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }

        [JsonProperty("yt:videoId")]
        public string Id { get; set; }              
    }
}
