using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EnglishDigit
{
    public static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        string word = LastDigit(number);
        Console.WriteLine("The last digit is {0}", word);
    }

    public static string LastDigit(int number)
    {
        int lastDigit = number % 10;
        string lastDigitAsWord = string.Empty;
        switch (lastDigit)
        {
            case 1: lastDigitAsWord = "One";
                break;
            case 2: lastDigitAsWord = "Two"; 
                break;
            case 3: lastDigitAsWord = "Three";
                break;
            case 4: lastDigitAsWord = "Four"; 
                break;
            case 5: lastDigitAsWord = "Five";
                break;
            case 6: lastDigitAsWord = "Six"; 
                break;
            case 7: lastDigitAsWord = "Seven"; 
                break;
            case 8: lastDigitAsWord = "Eight";
                break;
            case 9: lastDigitAsWord = "Nine";
                break;
            case 0: lastDigitAsWord = "Zero"; 
                break;
        }

        return lastDigitAsWord;
    }
}