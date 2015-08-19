using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NumeralSystems
{
    public static void Main()
    {
        Console.WriteLine("Enter decimal number:");
        int decimalNumber = int.Parse(Console.ReadLine());
        int decimalResult = decimalNumber;
        int bin = 0;
        string binaryResult = string.Empty;
        while (decimalResult > 0)
        {
            bin = decimalResult >= 2 ? decimalResult % 2 : 1;
            binaryResult += bin;
            decimalResult = decimalResult / 2;
        }

        char[] binaryArray = binaryResult.ToCharArray();
        Array.Reverse(binaryArray);
        string finalBinaryResult = new string(binaryArray);
        Console.WriteLine("The binary representation of the decimal number is:");
        Console.WriteLine("{0}", finalBinaryResult);
    }
}