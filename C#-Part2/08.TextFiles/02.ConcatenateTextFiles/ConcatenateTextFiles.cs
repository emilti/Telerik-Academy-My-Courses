using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConcatenateTextFiles
{
    public static void Main()
    {
        var readers = new List<StreamReader>();
        var first = new StreamReader(@"..\..\textfile.txt");
        var second = new StreamReader(@"..\..\textfile2.txt");
        readers.Add(first);
        readers.Add(second);      
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 2; i++)
        {
            using (readers[i])
            {               
                string allText = readers[i].ReadToEnd();               
                sb.Append(allText);
                sb.Append("\n");
                if (i == 1)
                {
                    StreamWriter streamWriter = new StreamWriter(@"..\..\all.txt");
                    using (streamWriter)
                    {
                        streamWriter.Write(sb.ToString());
                        Console.WriteLine(sb.ToString());                        
                    }
                }
            }
        }
    }
}