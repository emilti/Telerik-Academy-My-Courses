using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class RemoveWords
{
    public static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader(@"..\..\removewords.txt");
            string removingWords = string.Empty;
            List<string> blackList = new List<string>();
            using (reader)
            {
                removingWords = reader.ReadToEnd();
                string resultForRemovingList = Regex.Replace(removingWords, "[^a-zA-Z0-9_.\n]+", string.Empty, RegexOptions.Compiled);
                blackList = resultForRemovingList.Split(' ', ',', '\n').ToList();
            }

            StreamReader reader2 = new StreamReader(@"..\..\textfile.txt");
            string textForRemoving = reader2.ReadToEnd();
            string result = textForRemoving;
            StringBuilder pattern = new StringBuilder(@"(\\s)");
            foreach (string item in blackList)
            {
                pattern.AppendFormat("|({0})", item);
            }

            result = Regex.Replace(textForRemoving, pattern.ToString(), string.Empty);
            Console.WriteLine(result);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}