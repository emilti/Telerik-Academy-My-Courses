using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class ParseTags
{
    public static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        string searchForThisOpen = "<upcase>";
        string searchForThisClose = "</upcase>";
        StringBuilder sb = new StringBuilder();
        string sub = string.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != '<')
            {
                sb.Append(input[i]);
            }

            if (i < input.Length - 8)
            {
                sub = input.Substring(i, 8);
            }

            if (sub.Equals(searchForThisOpen))
            {
                int j;
                for (j = i + 9; j < input.Length; j++)
                {
                    string closeSub = input.Substring(j, 9);
                    if (closeSub.Equals(searchForThisClose))
                    {
                        for (int m = i + 8; m < j; m++)
                        {
                            sb.Append(input[m].ToString().ToUpper());
                        }

                        break;
                    }
                }

                i = j + 8;
                sub = string.Empty;
            }
        }

        Console.WriteLine(sb.ToString());

        // Another solution       
        // Regex rgx = new Regex("<upcase> (.*n?) </upcase>");
        // (?<=beginningstringname)(.*\n?)(?=endstringname)
        // var result = rgx.Replace(input,word => word.Groups[1].Value.ToUpper());
        // Console.WriteLine(result);
    }
}