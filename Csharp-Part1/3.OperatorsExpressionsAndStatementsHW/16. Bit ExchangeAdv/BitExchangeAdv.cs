using System;

// Problem 16.** Bit Exchange (Advanced)
//
//    Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//    The first and the second sequence of bits may not overlap.
public class BitsExchangeAdv
{
    public static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        long result = number;
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int interval = int.Parse(Console.ReadLine());
        int posBegin = 0;
        int posEnd = 0;
        if (first > second)
        {
            posEnd = first;
            posBegin = second;
        }
        else
        {
            posEnd = second;
            posBegin = first;
        }

        bool checkUpperLimit = posEnd + interval - 1 < 32 && posEnd < 32;
        bool checkBottomLimit = posBegin + interval - 1 >= 0 && posBegin >= 0;
        bool checkOverlap = posBegin + interval < posEnd;
        for (int pos = posBegin, countFromZero = 0; pos < posBegin + interval && 
             checkBottomLimit == true && checkUpperLimit == true &&
             checkOverlap == true; pos++, countFromZero++)
        {
            long maskBegining = 1 << pos;
            long nAndMaskBegining = result & maskBegining;
            long bitBeginingPart = nAndMaskBegining >> pos;

            long maskEnding = 1 << (posEnd + countFromZero);
            long nAndMaskEnding = result & maskEnding;
            long bitEndingPart = nAndMaskEnding >> (posEnd + countFromZero);

            if (bitBeginingPart != bitEndingPart && bitBeginingPart == 0)
            {
                long targetMaskBegining = 1 << pos;
                result = result | targetMaskBegining;

                long targetMaskEnding = ~(1 << (countFromZero + posEnd));
                result = result & targetMaskEnding;
            }
            else if (bitBeginingPart != bitEndingPart && bitBeginingPart == 1)
            {
                long targetMaskEnding = 1 << (countFromZero + posEnd);
                result = result | targetMaskEnding;

                long targetMaskBegining = ~(1 << pos);
                result = result & targetMaskBegining;
            }           
        }

        if (checkUpperLimit == false || checkBottomLimit == false)
        {
            Console.WriteLine("Out of Range");
        }
        else if (checkOverlap == false)
        {
            Console.WriteLine("Overlap");
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}