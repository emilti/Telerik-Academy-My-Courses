using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SaveSortedNames
{
    public static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\names.txt");
        using (reader)
        {
            string line = string.Empty;
            List<string> names = new List<string>();
            do
            {
                line = reader.ReadLine();
                names.Add(line);
            } 
            while (line != null);

            names.Sort();
            StreamWriter writer = new StreamWriter(@"..\..\sorted_names.txt");
            using (writer)
            {
                for (int i = 0; i < names.Count; i++)
                {
                    writer.WriteLine(names[i]);
                }
            }
        }
    }
}