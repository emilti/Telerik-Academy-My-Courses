namespace Recursion
{
    using System;

    /// <summary>
    /// 06.Write a program for generating and printing all subsets of k strings from given set of strings.
    /// Example: s = {test, rock, fun}, k=2 → (test rock), (test fun), (rock fun)
    /// </summary>
    public class VariationsOfSetWithoutRepetition
    {
        private static int k;
        private static int n;
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

            Console.WriteLine("K = ");
            k = int.Parse(Console.ReadLine());
            loops = new string[k];
            NestedLoops(0, 1);
        }

        public static void NestedLoops(int currentLoop, int start)
        {
            if (currentLoop == k)
            {
                PrintLoops();
                return;
            }

            for (int counter = start; counter <= n; counter++)
            {
                loops[currentLoop] = elements[counter - 1];
                NestedLoops(currentLoop + 1, counter + 1);
            }
        }

        public static void PrintLoops()
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", loops[i]);
            }

            Console.WriteLine();
        }
    }
}