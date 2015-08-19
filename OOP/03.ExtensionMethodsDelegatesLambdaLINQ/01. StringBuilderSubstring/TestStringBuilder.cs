namespace NewStringBuilderSubstring
{
    using System;    
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using StringBuilderSubstring;   

    public class TestStringBuilder
    {        
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Enter string:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter index:");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length:");
            int length = int.Parse(Console.ReadLine());
            sb.Append(input);
            StringBuilder subStr = sb.Substring(index, length);
            Console.WriteLine(subStr.ToString());            
        }
    }
}
