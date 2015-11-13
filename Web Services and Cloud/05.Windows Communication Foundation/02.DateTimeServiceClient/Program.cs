namespace _02.DateTimeServiceClient
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new MyService.DateTimeServiceClient();
            string result = client.GetDayOfWeekInBulgarian(new DateTime(2015, 11, 12));
            Console.OutputEncoding = System.Text.Encoding.GetEncoding("Cyrillic");
            Console.InputEncoding = System.Text.Encoding.GetEncoding("Cyrillic");
            Console.WriteLine(result);
        }
    }
}
