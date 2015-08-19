using System;
using System.Linq;

// Problem 5. Third Digit is 7?
//
//    Write an expression that checks for given integer if its third digit from right-to-left is 7.
public class ThirdDigitIs7
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());     
        int finalNumber = number / 100;
        bool isSeven = false;
        if (finalNumber % 10 == 7)
        {
            isSeven = true;
            Console.WriteLine("Third digit is 7: {0}", isSeven);
        }
        else
        {
            isSeven = false;
            Console.WriteLine("Third digit is 7: {0}", isSeven);
        }              
    }
}