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
        Console.WriteLine("The minimal number in the sequence is {0}", GetMin(1.2, 2.3, 3.3, 4.4, 5.2, 6.3, 7.2, 8.2, 9, -110.2));
        Console.WriteLine("The maximal number in the sequence is {0}", GetMax(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        Console.WriteLine("The average in the sequence is {0}", GetAverage(1.2, 2.3, 3.9, 4.4, 5.5, 6.6));
        Console.WriteLine("The sum of the numbers in the sequence is {0}", GetSum(1.2, 2.4, 3.3));
        Console.WriteLine("The product of the numbers in the sequence is {0}", GetProduct(1.2, 2.2, 3.3));
    }

    public static T GetMin<T>(params T[] numbers)
    {
        dynamic min = int.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        return min;
    }

    public static T GetMax<T>(params T[] numbers)
    {
        dynamic max = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }

    public static T GetAverage<T>(params T[] numbers)
    {
        dynamic sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        dynamic average = (double)sum / numbers.Length;
        return average;
    }

    public static T GetSum<T>(params T[] numbers)
    {
        dynamic sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    public static T GetProduct<T>(params T[] numbers)
    {
        dynamic product = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }

        return product;
    }
}