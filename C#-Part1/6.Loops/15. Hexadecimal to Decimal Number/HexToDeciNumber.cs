using System;

public class HexToDecNumber
{
    public static void Main()
    {
        Console.WriteLine("Enter hexadecimal number");
        string hexNumber = Console.ReadLine();
        char[] arrayOfChars = hexNumber.ToCharArray();
        ulong decNumber = 0;
       
        ulong mul = 0;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (arrayOfChars[i])
            {
                case '0': mul = 0; 
                    break;
                case '1': mul = 1;
                    break;
                case '2': mul = 2;
                    break;
                case '3': mul = 3; 
                    break;
                case '4': mul = 4;
                    break;
                case '5': mul = 5;
                    break;
                case '6': mul = 6;
                    break;
                case '7': mul = 7;
                    break;
                case '8': mul = 8;
                    break;
                case '9': mul = 9;
                    break;
                case 'A': mul = 10; 
                    break;
                case 'B': mul = 11;
                    break;
                case 'C': mul = 12; 
                    break;
                case 'D': mul = 13;
                    break;
                case 'E': mul = 14;
                    break;
                case 'F': mul = 15;
                    break;
            }

            decNumber = decNumber + ((ulong)Math.Pow(16, hexNumber.Length - i - 1) * mul);
        }

        Console.WriteLine("Decimal representation of the hexadecimal number:");
        Console.WriteLine(decNumber);
    }
}