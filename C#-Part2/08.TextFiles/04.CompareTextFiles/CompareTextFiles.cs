using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CompareTextFiles
{
    public static void Main()
    {
        string directory = @"..\..\";
        string[] linesA = File.ReadAllLines(Path.Combine(directory, "textfile1.txt"));
        string[] linesB = File.ReadAllLines(Path.Combine(directory, "textfile2.txt"));
        int countOfEqualLines = 0;
        int countOfDifferentLines = 0;
        for (int i = 0; i < linesA.Length; i++)
        {
            if (linesA[i] == linesB[i])
            {
                countOfEqualLines++;
            }
            else
            {
                countOfDifferentLines++;
            }
        }

        Console.WriteLine("Number of lines that are the same: {0}", countOfEqualLines);
        Console.WriteLine("Number of lines that are different: {0}", countOfDifferentLines);
    }
}