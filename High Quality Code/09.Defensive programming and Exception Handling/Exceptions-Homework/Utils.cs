namespace ExceptionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Utils
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            List<T> result = new List<T>();
            if (startIndex < 0)
            {
                throw new ArgumentException("startIndex should not be 0 or positive!");
            }

            if (count < 0)
            {
                throw new ArgumentException("count should not be 0 or positive!");
            }

            if (count + startIndex > arr.Length)
            {
                throw new ArgumentException("Count + startIndex should be less than the array length!");
            }

            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (count < 0)
            {
                throw new ArgumentException("count should be positive");
            }

            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("count is out of the range of the array");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static bool CheckPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
