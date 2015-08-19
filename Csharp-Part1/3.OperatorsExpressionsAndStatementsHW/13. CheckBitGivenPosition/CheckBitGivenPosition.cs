using System;

// Problem 13. Check a Bit at Given Position
//
//    Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
public class ExtractBitInteger
{
    public static void Main()
    {
        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the index p:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;
        bool isBit = bit == 1;
        Console.WriteLine(isBit);       
    }
}