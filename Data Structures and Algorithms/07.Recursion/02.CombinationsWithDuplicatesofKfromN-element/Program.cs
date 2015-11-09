using System;

public class Combinations
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
        NestedLoops(0);
    }

    public static void NestedLoops(int currentLoop)
    {
        if (currentLoop == numberOfLoops)
        {
            Console.WriteLine(string.Join(", ", loops));
            return;
        }

        for (int counter = 1; counter <= numberOfIterations; counter++)
        {
            loops[currentLoop] = counter;
            NestedLoops(currentLoop + 1);
        }
    }
}