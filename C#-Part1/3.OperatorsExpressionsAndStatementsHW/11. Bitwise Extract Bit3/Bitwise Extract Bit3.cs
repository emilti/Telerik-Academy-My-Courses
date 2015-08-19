using System;
using System.Linq;

// Problem 11. Bitwise: Extract Bit #3
//
//    Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//    The bits are counted from right to left, starting from bit #0.
//    The result of the expression should be either 1 or 0.
public class BitwiseExtractBit3
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        
        int p = 3;
        int mask = 1 << p;        
        int nAndMask = number & mask;  
        int bit = nAndMask >> p;  
        Console.WriteLine("The bit at the third place is {0}", bit);           
    }
}