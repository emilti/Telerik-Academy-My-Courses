using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OddLines
{
    public static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\textfile.txt");
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);                   
                }

                line = reader.ReadLine();
            }
        }
    }
}