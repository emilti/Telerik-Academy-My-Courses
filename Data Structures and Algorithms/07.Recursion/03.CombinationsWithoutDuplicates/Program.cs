using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CombinationsOfSet
{
    private static int numberOfLoops;
    private static int numberOfIterations;
    private static int[] loops;

    public static void Main()
    {
        Console.Write("N = ");
        numberOfIterations = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        numberOfLoops = int.Parse(Console.ReadLine());
        loops = new int[numberOfLoops];
        NestedLoops(0, 1);
    }

    public static void NestedLoops(int currentLoop, int start)
    {
        if (currentLoop == numberOfLoops)
        {
            PrintLoops();
            return;
        }

        for (int counter = start; counter <= numberOfIterations; counter++)
        {
            loops[currentLoop] = counter;
            NestedLoops(currentLoop + 1, counter + 1);
        }
    }

    public static void PrintLoops()
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            Console.Write("{0} ", loops[i]);
        }

        Console.WriteLine();
    }
}