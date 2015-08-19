using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class PrefixTest
{
    public static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\textfile.txt");
        string alltext = string.Empty; 
        using (reader)
        {
            alltext = reader.ReadToEnd();
        }

        Regex rgx = new Regex(@"\stest(?<=).*?(?=\s)");
        StringBuilder sb = new StringBuilder();
        string result = rgx.Replace(alltext, string.Empty);
        for (int i = 0; i < result.Length; i++)
        {
            if ((result[i] >= 'a' && result[i] <= 'z') || (result[i] >= 'A' && result[i] <= 'Z') ||
                (result[i] >= '0' && result[i] <= '9') || result[i] == '_' || result[i] == '.' || result[i] == ','
                || result[i] == ' ')
            {
                sb.Append(result[i]);
            }

            if (i > 0 && result[i - 1] == '\r' && result[i] == '\n')
            {
                sb.Append("\r\n");
            }
        }

        result = sb.ToString();
            Console.Write(result);
            StreamWriter writer = new StreamWriter(@"..\..\temp.txt");
        using (writer)
        {
            writer.Write(result);
        }

        File.Delete(@"..\..\textfile.txt");
        File.Move(@"..\..\temp.txt", @"..\..\textfile.txt");
    }
}