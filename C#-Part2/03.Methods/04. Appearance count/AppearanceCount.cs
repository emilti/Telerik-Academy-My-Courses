using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AppearanceCount
{
    public static void Main()
    {
        // *Zero tests
        // int[] arrayOfInts = { 2, 4, 5, 1, 2, 4, 5, 6 };        
        int[] arrayOfInts = { 2, 4, -5, -1, 2, 4, -5, 6 };

        // For manual entering you can uncomment this code:
        // Console.WriteLine("Enter the length of the array:");
        // int len=int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter the array:");
        // int[] arrayOfInts=new int[len];
        // for (int i=0;i<len;i++)
        // {
        //     arrayOfInts[i] = int.Parse(Console.ReadLine());
        // }
        Console.WriteLine("Enter the checked number:");
        int number = int.Parse(Console.ReadLine());
        int numberCountInArray = CheckNumber(arrayOfInts, number);
        Console.WriteLine("The number {0} appears in the given array {1} time(s).", number, numberCountInArray);
        Console.WriteLine("Result from the checking program:");
        Console.WriteLine(CheckAppearanceTest());
    }

    public static int CheckNumber(int[] array, int number)
    {
        int numberCountInArray = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                numberCountInArray++;
            }
        }

        return numberCountInArray;      
    }

    private static string CheckAppearanceTest()
    {
        if (CheckNumber(new int[] { 2, 4, -5, -1, 2, 4, -5, 6 }, 8) != 0 ||
            CheckNumber(new int[] { -2, -3, -4 }, -2) != 1)
        {
            return "Fail";
        }

        return "Success";
    }
}   
