namespace ConsoleClient
{
    using System;

    public class MainProram
    {
        public static void Main(string[] args)
        {
            var client = new StringsTestServiceClient();
            int result = client.TestString("ab", "ababab");
            Console.WriteLine("The number of times the first string is contained in the second one: {0}", result);
        }
    }
}
