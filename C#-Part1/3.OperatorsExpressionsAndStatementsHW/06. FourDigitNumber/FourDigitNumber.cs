using System;

// Problem 6. Four-Digit Number
//
//    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//        Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//        Prints on the console the number in reversed order: dcba (in our example 1102).
//        Puts the last digit in the first position: dabc (in our example 1201).
//        Exchanges the second and the third digits: acbd (in our example 2101).
//
// The number has always exactly 4 digits and cannot start with 0.
public class FourDigitNumber
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int fourthDigit = number % 10;
        int thirdDigit = (number / 10) % 10;
        int secondDigit = (number / 100) % 10;
        int firstDigit = number / 1000;
        Console.WriteLine("Sum of the digits = {0}", firstDigit + secondDigit + thirdDigit + fourthDigit);
        Console.WriteLine("Number in reversed order {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine("Last digit in the first position {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
        Console.WriteLine("Exchanges the second and the third digits: {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
    }
}