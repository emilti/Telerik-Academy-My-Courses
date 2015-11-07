namespace ArticlesSearcher
{
    using System;
    /// <summary>
    /// Write a console application, which searches for news articles by given a query stringand a count of articles to retrieve.
    /// The application should ask the user for input and print the Titles and URLs of the articles.
    /// For news articles search, use the Feedzilla API and use one of WebClient, HttpWebRequest or HttpClient.
    /// Feedzilla API was inaccessible, so I made application for consuming service from www.justice.gov. 
    /// I get the body of the press_releases using GET query to http://www.justice.gov/api/v1/press_releases
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            MyHttpClient my = new MyHttpClient();
            my.DownloadPageAsync();
            
            Console.WriteLine("Downloading page...");
            Console.ReadLine();
        }        
    }
}
