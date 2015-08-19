using System;

// Problem 14. Modify a Bit at Given Position
//
//    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//    Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
public class ModifyBitGivenPosition
{
    public static void Main()
    {
        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the index p:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value v:");
        int targetBit = int.Parse(Console.ReadLine());
        
        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;
        int result = 0;
        if (bit != targetBit && bit == 0)
        {
            int targetMask = 1 << p;        
            result = number | targetMask;            
        }
        else if (bit != targetBit && bit == 1)
        {
            int targetMask = ~(1 << p);       
            result = number & targetMask;             
        }
        else if (bit == targetBit)
        {
            result = number;
        }

        Console.WriteLine(result);
    }
}