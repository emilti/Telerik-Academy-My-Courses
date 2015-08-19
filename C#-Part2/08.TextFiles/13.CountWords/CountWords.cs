using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class CountWords
{
    public static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader(@"..\..\words.txt");
            string words = string.Empty;
            List<string> list = new List<string>();
            using (reader)
            {
                words = reader.ReadToEnd();
                string resultForTheList = Regex.Replace(words, "[^a-zA-Z0-9_.\n]+", string.Empty, RegexOptions.Compiled);
                list = resultForTheList.Split(' ', ',', '\n').ToList();
            }

            StreamReader reader2 = new StreamReader(@"..\..\test.txt");
            string textForCheck = reader2.ReadToEnd();
            string[] source = textForCheck.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int[] countForEachWord = new int[list.Count];
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            for (int i = 0; i < list.Count; i++)
            {
                var matchQuery = from word in source
                                 where word.ToLowerInvariant() == list[i].ToLowerInvariant()
                                 select word;

                countForEachWord[i] = matchQuery.Count();
                myDictionary.Add(list[i], countForEachWord[i]);
            }

            var sortedDict = from entry in myDictionary orderby entry.Value descending select entry;
            StreamWriter writer = new StreamWriter(@"..\..\result.txt");
            using (writer)
            {
                foreach (var sortedCell in sortedDict)
                {
                    writer.WriteLine("Key = {0}, Value = {1}", sortedCell.Key, sortedCell.Value);
                    Console.WriteLine("Key = {0}, Value = {1}", sortedCell.Key, sortedCell.Value);
                }
            }
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