namespace Longest
{
    using System;
    using System.Linq;

    public class LongestString
    {
        public static void Main()
        {
            string[] arrayOfString = { "aaa", "bbbbbb", "cc", "dddd" };
            string longest = (from str in arrayOfString
                              orderby str.Length descending
                              select str).First();
            Console.WriteLine("The longest string in the array is:");
            Console.WriteLine(longest);
        }
    }
}
