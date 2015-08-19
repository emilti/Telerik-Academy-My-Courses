namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public static class IEnumerableExt
    {
        public static double SumExt<T>(this IEnumerable<T> originalEnumerable)
           where T : IConvertible, IComparable
        {
            double sum = 0;
            foreach (var item in originalEnumerable)
            {
                sum += Convert.ToDouble(item);
            }

            return sum;
        }

        public static double MaxExt<T>(this IEnumerable<T> originalEnumerable)
          where T : IConvertible, IComparable
        {
            double max = double.MinValue;
            foreach (var item in originalEnumerable)
            {
                if (Convert.ToDouble(item) > max)
                {
                    max = Convert.ToDouble(item);
                }
            }

            return max;
        }

        public static double MinExt<T>(this IEnumerable<T> originalEnumerable)
        where T : IConvertible, IComparable
        {
            double min = double.MaxValue;
            foreach (var item in originalEnumerable)
            {
                if (Convert.ToDouble(item) < min)
                {
                    min = Convert.ToDouble(item);
                }
            }

            return min;
        }

        public static double ProductExt<T>(this IEnumerable<T> originalEnumerable)
        where T : IConvertible, IComparable
        {
            double product = 1;
            foreach (var item in originalEnumerable)
            {
                product *= Convert.ToDouble(item);
            }

            return product;
        }

       public static double AverageExt<T>(this IEnumerable<T> originalEnumerable)
       where T : IConvertible, IComparable
        {
            double sum = 0;
            double counter = 0;
            foreach (var item in originalEnumerable)
            {
                sum += Convert.ToDouble(item);
                counter++;
            }

            double average = sum / counter;
            return average;
        }
    }
}