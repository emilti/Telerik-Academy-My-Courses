using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReplaceSubString
{
    public static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\start.txt");
        using (reader)
        {
            StringBuilder sb = new StringBuilder();
            string allText = reader.ReadToEnd();
            for (int i = 0; i < allText.Length; i++)
            {
                if (i < allText.Length - 4)
                {
                    string sub = allText.Substring(i, 5);
                    if (sub == "start")
                    {
                        sb.Append("finish");
                        i = i + 4;
                    }
                    else
                    {
                        sb.Append(allText[i]);
                    }
                }
                else
                {
                    sb.Append(allText[i]);
                }                
            }

            StreamWriter streamWriter = new StreamWriter(@"..\..\end.txt");
            using (streamWriter)
            {
                streamWriter.Write(sb.ToString());               
            }

            Console.WriteLine(sb.ToString());
        }        
    }
}