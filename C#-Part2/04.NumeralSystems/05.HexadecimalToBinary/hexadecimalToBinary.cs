using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HexadecimalToBinary
{
    public static void Main()
    {
        Console.WriteLine("Enter hexadecimal number:");
        string hexNumber = Console.ReadLine();
        char[] chars = hexNumber.ToCharArray();       
        string binaryRepresentation = string.Empty;
        string binaryNumber = string.Empty;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (chars[i])
            {
                case '0': binaryRepresentation = "0000";
                    break;
                case '1': binaryRepresentation = "0001"; 
                    break;
                case '2': binaryRepresentation = "0010";
                    break;
                case '3': binaryRepresentation = "0011";
                    break;
                case '4': binaryRepresentation = "0100"; 
                    break;
                case '5': binaryRepresentation = "0101"; 
                    break;
                case '6': binaryRepresentation = "0110"; 
                    break;
                case '7': binaryRepresentation = "0111"; 
                    break;
                case '8': binaryRepresentation = "1000"; 
                    break;
                case '9': binaryRepresentation = "1001"; 
                    break;
                case 'A': binaryRepresentation = "1010";
                    break;
                case 'B': binaryRepresentation = "1011";
                    break;
                case 'C': binaryRepresentation = "1100"; 
                    break;
                case 'D': binaryRepresentation = "1101";
                    break;
                case 'E': binaryRepresentation = "1110"; 
                    break;
                case 'F': binaryRepresentation = "1111"; 
                    break;
            }

            binaryNumber = binaryNumber + binaryRepresentation;           
        }

        Console.WriteLine("Binary representation of the hexadecimal number is:");
        Console.WriteLine(binaryNumber);
    }
}