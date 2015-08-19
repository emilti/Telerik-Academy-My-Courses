using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BinaryToHexadecimal
{
    public static void Main()
    {
        char hex = ' ';
        string hexadecimalNumber = string.Empty;
        Console.WriteLine("Enter binary number:");
        string binary = Console.ReadLine();
        int diff = binary.Length % 4;
        if (diff > 0)
        {
            binary = new string('0', 4 - diff) + binary;
        }

        // Console.WriteLine(binary);
        string[] array = new string[binary.Length / 4];
        for (int i = 0, j = 0; i < binary.Length; i += 4, j++)
        {
            array[j] = binary.Substring(i, 4);

            // Console.WriteLine(array[j]);
        }

        for (int i = 0; i < array.Length; i++)
        {
            switch (array[i])
            {
                case "0000": hex = '0';
                    break;
                case "0001": hex = '1'; 
                    break;
                case "0010": hex = '2';
                    break;
                case "0011": hex = '3';
                    break;
                case "0100": hex = '4';
                    break;
                case "0101": hex = '5';
                    break;
                case "0110": hex = '6';
                    break;
                case "0111": hex = '7';
                    break;
                case "1000": hex = '8'; 
                    break;
                case "1001": hex = '9'; 
                    break;
                case "1010": hex = 'A';
                    break;
                case "1011": hex = 'B'; 
                    break;
                case "1100": hex = 'C'; 
                    break;
                case "1101": hex = 'D'; 
                    break;
                case "1110": hex = 'E'; 
                    break;
                case "1111": hex = 'F'; 
                    break;
            }

            hexadecimalNumber = hexadecimalNumber + hex;
        }

        Console.WriteLine("Hexadecimal representation of the binary number is:");
        Console.WriteLine(hexadecimalNumber);
    } 
}