using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StringLength
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        Console.WriteLine("Enter string:");
        int i, count = 0;

        while ((i = Console.Read()) != 13) 
        {
            if (++count > 20)
            {
                break;
            }

            sb.Append((char)i);            
        }

        if (sb.Length < 20)
        {
            for (int j = sb.Length; j < 20; j++)
            {
                sb.Append('*');
            }
        }

        Console.WriteLine("The result string is:");
        Console.WriteLine(sb.ToString());
    }
}