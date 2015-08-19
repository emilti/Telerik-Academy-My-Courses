using System;

public class AllocateArray
{
    public static void Main()
    {
        int[] arrayOfInt = new int[20];
        for (int i = 0; i < 20; i++)
        {
            arrayOfInt[i] = 5 * i;

            // Console.WriteLine("{0}->{1}",i,arrayOfInt[i]);
        }

        Console.WriteLine(string.Join(",", arrayOfInt));
    }
}