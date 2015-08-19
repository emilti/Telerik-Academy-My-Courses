using System;

// Problem 14.* Print the ASCII Table
//
//    Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
//
// Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
//
// Note: You may need to use for-loops (learn in Internet how).
public class PrintTheASCIITable
{
    public static void Main()
    {
        for (int count = 0; count < 256; count++)
        {
            char symbol = (char)count;
            Console.WriteLine("count: {0} sign: {1}", count, symbol);
        }
    }
}