using System;

public class PrintaSequence
{
    public static void Main()
    {
        int odd = 2;
        int even = -3;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {                
                Console.Write("{0}", odd);
                odd += 2;
            }
            else
            {                
                Console.Write("{0}", even);
                even -= 2;
            }

            if (i < 9)
            {
                Console.Write(", ", odd);
            }
        }
    }
}