namespace Recursion
{       
    using System;

    /// <summary>
    /// 05.Write a recursive program for generating and printing all ordered k-element subsets from n-element set(variations Vkn).
    /// Example: n=3, k=2, set = {hi, a, b} → (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b) 
    /// </summary>
    public class VariationsOfSet
    {
        private static int n;
        private static int k;
        private static string[] loops;
        private static string[] elements;

        public static void Main()
        {
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter strings:");
            elements = new string[n];
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                elements[i] = line;
            }

            Console.Write("K = ");
            k = int.Parse(Console.ReadLine());
            loops = new string[k];
            NestedLoops(0);
        }

        public static void NestedLoops(int currentLoop)
        {
            if (currentLoop == k)
            {
                Console.WriteLine(string.Join(", ", loops));
                return;
            }

            for (int counter = 1; counter <= n; counter++)
            {
                loops[currentLoop] = elements[counter - 1];
                NestedLoops(currentLoop + 1);
            }
        }
    }
}