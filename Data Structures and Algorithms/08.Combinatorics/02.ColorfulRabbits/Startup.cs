namespace ColorfulRabbits
{
    using System;
    using System.Collections.Generic;   

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> keys = new List<int>();
            List<int> counts = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                int index = keys.FindIndex(item => item == currentNumber);
                if (index >= 0)
                {
                    counts[index] += 1;
                }
                else
                {
                    keys.Add(currentNumber);
                    counts.Add(1);
                }
            }

            long rabbits = 0;
            for (int i = 0; i < keys.Count; i++)
            {
                double currentresult = Math.Ceiling((double)counts[i] / ((double)keys[i] + 1.0));
                long rabbitsForCurrentKey = (long)currentresult * ((long)keys[i] + 1);
                rabbits += rabbitsForCurrentKey;
            }

            Console.WriteLine(rabbits);
        }
    }
}
