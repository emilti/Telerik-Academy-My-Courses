namespace Statistics
{
    using System;

    public class Statistics
    {      
        public void PrintStatistics(double[] inputArray, int count)
        {            
            double max = FindMax(inputArray, count);
            Console.WriteLine(max);
            double min = FindMin(inputArray, count);
            Console.WriteLine(min);
            double sum = FindSum(inputArray, count);
            Console.WriteLine(sum);         
        }

        private static double FindSum(double[] inputArray, int count)
        {
            double sum = 0;           
            for (int i = 0; i < count; i++)
            {
                sum += inputArray[i];
            }

            return sum;
        }

        private static double FindMin(double[] inputArray, int count)
        {
            double min = double.MaxValue;
            for (int i = 0; i < count; i++)
            {
                if (inputArray[i] < min)
                {
                    min = inputArray[i];
                }
            }

            return min;
        }

        private static double FindMax(double[] inputArray, int count)
        {
            double max = double.MinValue;
            for (int i = 0; i < count; i++)
            {
                if (inputArray[i] > max)
                {
                    max = inputArray[i];
                }
            }

            return max;
        }      
    }
}
