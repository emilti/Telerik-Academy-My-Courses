using System;
using System.Numerics;

public class TrailingZeroesinN
{
    public static void Main()
    {
        Console.WriteLine("Enter number:");
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger result = 1;
        for (BigInteger i = 1; i <= number; i++)
        {
            result = result * i;
        }

        string numberStr = result.ToString();
        char[] arrayOfChars = numberStr.ToCharArray();
        int trailingZeros = 0;
        for (int j = arrayOfChars.Length - 1; j >= 0; j--)
        {
            if (arrayOfChars[j] == '0')
            {
                trailingZeros++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("The count of the trailing zeros is {0}.", trailingZeros);
    }
}