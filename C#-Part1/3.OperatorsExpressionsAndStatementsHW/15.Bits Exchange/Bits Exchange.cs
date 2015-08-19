using System;

// Problem 15.* Bits Exchange
//
//    Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
public class BitsExchange
{
    public static void Main()
    {
        long number = uint.Parse(Console.ReadLine());
        long result = number;
        for (int pos = 3; pos < 6; pos++)
        {
            long maskBegining = 1 << pos;
            long nAndMaskBegining = number & maskBegining;
            long bitBeginingPart = nAndMaskBegining >> pos;

            long maskEnding = 1 << (pos + 21);
            long nAndMaskEnding = number & maskEnding;
            long bitEndingPart = nAndMaskEnding >> (pos + 21);
            
            if (bitBeginingPart != bitEndingPart && bitBeginingPart == 0)
            {
                long targetMaskBegining = 1 << pos;
                result = result | targetMaskBegining;
                long targetMaskEnding = ~(1 << (pos + 21));
                result = result & targetMaskEnding;
            }
            else if (bitBeginingPart != bitEndingPart && bitBeginingPart == 1)
            {
                long targetMaskEnding = 1 << (pos + 21);
                result = result | targetMaskEnding;
                long targetMaskBegining = ~(1 << pos);
                result = result & targetMaskBegining;
            }

            string check = Convert.ToString(result, 2).PadLeft(32, '0');     
        }

        Console.WriteLine(result);
    }
}