using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RemoveElements
{
    public static void Main()
    {
        // For check you can comment the row below and uncomment the row which have //* above them
        int[] intsArray = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };

        // int[] IntsArray = { 6, 1, 4, 3, 0, 3,1, 4, 2 };        
        int len = 9;
        List<int> listOfInts = new List<int>();

        // *comment the row below for thorough check
        listOfInts.AddRange(intsArray);

        // *uncoment the two rows below for thorough check
        // Console.WriteLine("Enter the length of the array");
        // int len = int.Parse(Console.ReadLine());             
        List<int> sortedList = new List<int>();
        List<int> listForRemoving = new List<int>();
        int lengthSorted = 0;
        int maxLengthSorted = 0;
        bool isSorted = true;

        // *Comment all until the next //**
        // for (int i = 0; i < len; i++)
        // {
        //     listOfInts.Add(int.Parse(Console.ReadLine()));
        // }
        // *
        List<int> interimList = new List<int>(listOfInts);        
        double binaryTop = Math.Pow(2, len) - 1;
        for (int i = 0; i <= binaryTop; i++)
        {
            len = listOfInts.Count;
            for (int j = 0; j < len; j++)
            {
                int mask = 1 << j;
                int maskAndI = mask & i;
                int bit = maskAndI >> j;
                if (bit == 1)
                {
                    listForRemoving.Add(j);
                }

                if (j == len - 1 && listForRemoving.Count > 0)
                {
                    for (int k = len - 1; k >= 0; k--)
                    {
                        if (listForRemoving.Contains(k))
                        {
                            interimList.RemoveAt(k);
                            len--;
                        }
                    }

                    for (int m = 1; m < len; m++)
                    {
                        if (interimList[m] < interimList[m - 1])
                        {
                            isSorted = false;
                            break;
                        }
                    }

                    if (isSorted == true)
                    {
                        lengthSorted = interimList.Count;
                        if (lengthSorted > maxLengthSorted)
                        {
                            sortedList = new List<int>(interimList);
                            maxLengthSorted = lengthSorted;
                            lengthSorted = 0;
                        }
                    }

                    isSorted = true;
                    listForRemoving.Clear();
                    interimList = new List<int>(listOfInts);
                }
            }
        }

        for (int n = 0; n < sortedList.Count; n++)
        {
            Console.Write("{0} ", sortedList[n]);
        }

        Console.WriteLine();
    }
}