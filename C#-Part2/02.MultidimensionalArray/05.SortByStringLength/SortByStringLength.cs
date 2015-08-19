using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SortStringLength
{
    public static void Main()
    {
        int len = 4;
        string[] stringsCollection = { "aaaaa", "bbbbbbbb", "ccc", "t" };

        // Console.WriteLine("Enter the length of the array:");
        // int len = int.Parse(Console.ReadLine());
        // string[] arrayOfStrings = new string[len];
        // for (int i=0;i<len;i++)
        // {
        //     arrayOfStrings[i]=Console.ReadLine();       
        // }
        int overallMinLength = 0;
        int minLengthIndex = 0;
        int currentMinLength = stringsCollection[0].Length;
        int start = 0;
        for (int i = 0; i < len; i++)
        {
            currentMinLength = stringsCollection[i].Length;
            overallMinLength = stringsCollection[i].Length;
            string swappedValue = string.Empty;
            for (int j = start; j < len; j++)
            {
                if (overallMinLength > stringsCollection[j].Length)
                {
                    minLengthIndex = j;
                    overallMinLength = stringsCollection[j].Length;
                }               
            }

            swappedValue = stringsCollection[i];
            stringsCollection[i] = stringsCollection[minLengthIndex];
            stringsCollection[minLengthIndex] = swappedValue;
            start++;
        }

        for (int i = 0; i < len; i++)
        {
            Console.WriteLine(stringsCollection[i]);
        }
    }
}