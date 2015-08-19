using System;
using System.Collections.Generic;

//Problem 4. Binary search
//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.


class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the array:");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer K");
        int[] arrayOfNumbers = new int[numberN];
        int numberK = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the array:");
        for (int i = 0; i < numberN; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arrayOfNumbers);
        int minValue = arrayOfNumbers[0];
        int searchedNumber = numberK;
        int indexOfSearchedNumber=-1;
        bool searching=true;
        bool noNumberFound=false;
        while (searching)
        {
            int index = Array.BinarySearch(arrayOfNumbers, searchedNumber);
            if (index < 0 && arrayOfNumbers[0] > searchedNumber)
            {
                noNumberFound = true;
                break;
            }
            if (index <0)
            {
                searchedNumber = searchedNumber - 1;
            }
            else
            {
                indexOfSearchedNumber = index;
                searching = false;
            }                   
        }
        if (noNumberFound==false)
        {
        Console.WriteLine("The number that is <=K is: {0}",searchedNumber);
        }
        else
        {
            Console.WriteLine("No number found that is <=K");
        }
    }
}

