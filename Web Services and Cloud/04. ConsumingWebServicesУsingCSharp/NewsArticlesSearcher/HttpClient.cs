namespace ArticlesSearcher
{   
    using System;
    using System.Collections.Generic;   
    using System.Net.Http;
    using System.Net.Http.Headers;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MyHttpClient
    {
        public async void DownloadPageAsync()
        {          
            string page = "http://www.justice.gov/api/v1/press_releases";

            // ... Use HttpClient.
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders
                      .Accept
                      .Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Other");
                using (HttpResponseMessage response = await client.GetAsync(page))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();                        
                        var result = DeserializeObject(data);
                        Console.WriteLine(result);
                        foreach (var item in result)
                        {
                            Console.WriteLine(item.Body);
                        }
                    }
                }
            }
        }

        private static List<Content> DeserializeObject(string response)
        {
            var jsonObject = JObject.Parse(response);
            var results = jsonObject["results"].Children();

            List<Content> content = new List<Content>();
            foreach (JToken result in results)
            {
                Content next = JsonConvert.DeserializeObject<Content>(result.ToString());
                content.Add(next);
            }

            return content;
        }
    }
}