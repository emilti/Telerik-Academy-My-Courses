namespace IEnumerableExtensions
{    
    using System;
    using System.Collections.Generic;
    using IEnumerableExtensions;

    public class TestExt
    {
        public static void Main()
        {
            double[] arrayOfDouble = { 1, 2, 3, 4 };

            // double[] arrayOfDouble = { -1, -2, -3, -4, -5 };
            double sum = arrayOfDouble.SumExt();
            double product = arrayOfDouble.ProductExt();
            double max = arrayOfDouble.MaxExt();
            double min = arrayOfDouble.MinExt();
            double average = arrayOfDouble.AverageExt();
            Console.WriteLine("Sum={0}", sum);
            Console.WriteLine("Product={0}", product);
            Console.WriteLine("Max={0}", max);
            Console.WriteLine("Min={0}", min);
            Console.WriteLine("Average={0}", average);
        }
    }
}