using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class IntegerCalclulations
{
    public static void Main()
    {
        Console.WriteLine("Sequence {1,2,3,4,5,6,7,8,9,10}");
        Console.WriteLine("The minimal number in the sequence is {0}", GetMin(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        Console.WriteLine("The maximal number in the sequence is {0}", GetMax(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        Console.WriteLine("The average in the sequence is {0}", GetAverage(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        Console.WriteLine("The sum of the numbers in the sequence is {0}", GetSum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        Console.WriteLine("The product of the numbers in the sequence is {0}", GetProduct(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
    }

    public static int GetMin(params int[] numbers)
    {
        int min = int.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        return min;
    }

    public static int GetMax(params int[] numbers)
    {
        int max = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }

    public static double GetAverage(params int[] numbers)
    {
        int sum = 0;
       
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        double average = (double)sum / numbers.Length;
        return average;
    }

    public static int GetSum(params int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }    
    
        return sum;
    }

    public static int GetProduct(params int[] numbers)
    {
        int product = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }

        return product;
    }
}