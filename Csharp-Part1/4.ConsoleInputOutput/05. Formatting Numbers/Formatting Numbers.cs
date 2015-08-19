using System;

// 5. Formatting Numbers
//
//    Write a program that reads 3 numbers:
//        integer a (0 <= a <= 500)
//        floating-point b
//        floating-point c
//    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//        The number a should be printed in hexadecimal, left aligned
//        Then the number a should be printed in binary form, padded with zeroes
//        The number b should be printed with 2 digits after the decimal point, right aligned
//        The number c should be printed with 3 digits after the decimal point, left aligned.
public class FormattingNumbers
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        string numberBinaryString = Convert.ToString(a, 2).PadLeft(10, '0'); 
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("{0,-10:x}|{1}|{2,10:f2}|{3,-10:f3}|", a, numberBinaryString, b, c);
    }
}