using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BinaryToDecimal
{
    public static void Main()
    {
        Console.WriteLine("Enter binary number:");
        string binaryNumber = Console.ReadLine();
        char[] binaryArray = binaryNumber.ToString().ToCharArray();
        Array.Reverse(binaryArray);
        double decimalNumber = 0;
        for (int i = 0; i < binaryArray.Length; i++)
        {
            decimalNumber = ((binaryArray[i] - '0') * Math.Pow(2, i)) + decimalNumber;
        }   
          
        Console.WriteLine("The decimal representation of the binary number is:");
        Console.WriteLine("{0}", decimalNumber);
    }
}