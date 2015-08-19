using System;
using System.Collections.Generic;

public class IndexOfLetters
{
    public static void Main()
    {
        Console.WriteLine("Enter string:");
        string input = Console.ReadLine();
        char[] inputToCharArray = input.ToCharArray();
        char[] arrayOfLetters = new char[26];

        for (int i = 0; i <= 25; i++)
        {
            arrayOfLetters[i] = (char)(i + 97);

            // Console.WriteLine("{0}",arrayOfLetters[i]);
        }

        Console.Write("The indexes of the letters from the array with the alphabet are:");
        Console.WriteLine();
        for (int l = 0; l < inputToCharArray.Length; l++)
        {
            for (int m = 0; m <= 25; m++)
            {
                if (arrayOfLetters[m] == inputToCharArray[l])
                {
                    Console.Write("{0} ", m);
                    break;
                }
            }
        }

        Console.WriteLine();
    }
}