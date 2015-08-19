using System;

// Problem 12. Null Values Arithmetic
//
//    Create a program that assigns null values to an integer and to a double variable.
//    Try to print these variables at the console.
//    Try to add some number or the null literal to these variables and print the result.
public class NullValuesArithmetic
{
    public static void Main()
    {
        int? nullVarInt = null;
        double? nullVarDouble = null;
        Console.WriteLine(nullVarInt);
        Console.WriteLine(nullVarDouble);
        nullVarInt = nullVarInt + 1;
        nullVarDouble = nullVarDouble + 2;
        Console.WriteLine(nullVarInt);
        Console.WriteLine(nullVarDouble);
    }
}