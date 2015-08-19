using System;

public class PrintaSequence
{
    public static void Main()
    {
        int odd = 2;
        int even = -3;
        for (int i = 0; i < 1000; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0}", odd);
                odd += 2;
            }
            else
            {
                Console.WriteLine("{0}", even);
                even -= 2;
            }            
        }
    }
}