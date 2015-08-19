using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LargestNumber
{
    public static void Main()
    {
        Console.WriteLine("Enter the three integers:");
        int x1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int maxValue = int.MinValue; 
        maxValue = GetMax(GetMax(x1, x2), x3);
        Console.WriteLine("Max value is: {0}", maxValue);
    }

    public static int GetMax(int num1, int num2)
    {
        if (num1 >= num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }   
    }
}