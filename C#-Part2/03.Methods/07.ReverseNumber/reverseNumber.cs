using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReverseNumber
{
    public static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        int reversedNumber = Reverse(number);
        Console.WriteLine("The reversed number is:");
        Console.WriteLine(reversedNumber);
    }

    public static int Reverse(int forReversing)
    {
        char[] digits = forReversing.ToString().ToCharArray();
        string result = string.Empty;
        int intResult = 0;
        for (int i = 0; i < digits.Length / 2; i++)
        {           
            char currentDigit = digits[i];
            digits[i] = digits[digits.Length - 1 - i];
            digits[digits.Length - 1 - i] = currentDigit;

            // result = result + digits[i];            
        }

        return intResult = int.Parse(string.Join(string.Empty, digits));        
    }
}