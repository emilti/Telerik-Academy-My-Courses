namespace BinaryPasswords
{
    using System;
    using System.Linq;

    public class Startup
    {        
        public static void Main()
        {
            string line = Console.ReadLine();
            var stars = line.ToCharArray().Where(s => s.CompareTo('*') == 0).ToList();           
            long count = 0;
            int k = stars.Count;
            count = (long)Math.Pow(2, k);
            Console.WriteLine(count);
        }
    }
}
