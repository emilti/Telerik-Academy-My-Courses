namespace CompanyWithStoredArticles
{
    using System;
    using System.Text;
    using Wintellect.PowerCollections;

    /// <summary>
    /// A large trade company has millions of articles, each described by barcode, vendor, title and price.
    /// Implement a data structure to store them that allows fast retrieval of all articles in given price range[x…y].
    /// Hint: use OrderedMultiDictionary<K, T> from Wintellect's Power Collections for .NET.
    /// </summary>
    public class MainProgram
    {
        public const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";


        public static void Main()
        {
            OrderedMultiDictionary<decimal, Article> articlesByPrice = new OrderedMultiDictionary<decimal, Article>(true);
            Random random = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                var barcode = random.Next(111111, 999999);
                var lengthTitle = random.Next(2, 20);
                string title = GetRandomString(lengthTitle, random);
                var lengthVendor = random.Next(2, 20);
                string vendor = GetRandomString(lengthVendor, random);
                var price = random.Next(1, 10000);
                Article article = new Article(barcode, vendor, title, price);
                articlesByPrice.Add(article.Price, article);
            }

            for (int i = 0; i < 20; i++)
            {
                var lowerBound = random.Next(1, 9950);
                var upperBound = lowerBound + 50;
                var articlesInRange = articlesByPrice.Range(lowerBound, true, upperBound, true);                
                Console.WriteLine("Articles in price range {0}- {1}: {2} articles",lowerBound, upperBound, articlesInRange.Values.Count);
            }
        }

        private static string GetRandomString(int length, Random random)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                var letter  = random.Next(0, Alphabet.Length);
                sb.Append(Alphabet[letter]);
            }

            return sb.ToString();
        }
    }
}
