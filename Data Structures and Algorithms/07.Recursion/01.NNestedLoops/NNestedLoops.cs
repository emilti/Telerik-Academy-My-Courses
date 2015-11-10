namespace Recursion
{
    using System;

    /// <summary>
    /// 01.Write a recursive program that simulates the execution of n nested loopsfrom 1 to n. 
    /// </summary>
    public class NNestedLoops
    {
        private static int numberOfLoops;
        private static int numberOfIterations;
        private static int[] loops;

        public static void Main()
        {
            Console.Write("N = ");
            numberOfLoops = int.Parse(Console.ReadLine());
            loops = new int[numberOfLoops];
            NestedLoops(0);
        }

        public static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                Console.WriteLine(string.Join(", ", loops));
                return;
            }

            for (int counter = 1; counter <= numberOfLoops; counter++)
            {
                loops[currentLoop] = counter;
                NestedLoops(currentLoop + 1);
            }
        }
    }
}