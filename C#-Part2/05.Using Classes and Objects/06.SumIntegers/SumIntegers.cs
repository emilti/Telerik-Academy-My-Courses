using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SumIntegers
{
    public static void Main()
    {
        Console.WriteLine("Enter numbers:");
        string input = Console.ReadLine();
        string[] stringsCollection = input.Split(' ');       
        int sum = 0;
        for (int i = 0; i < stringsCollection.Length; i++)
        {
            int number = int.Parse(stringsCollection[i]);
            sum += number;
        }

        Console.WriteLine("The sum of the numbers is:");
        Console.WriteLine(sum);
    }
}