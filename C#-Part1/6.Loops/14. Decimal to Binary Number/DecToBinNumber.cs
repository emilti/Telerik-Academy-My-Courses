using System;

public class DecToBinNumber
{
    public static void Main()
    {
        Console.WriteLine("Enter number decimal number:");
        ulong boundary = 0;
        ulong number = ulong.Parse(Console.ReadLine());
        bool start = false;
        Console.WriteLine("Binary representation of the decimal number:");
        for (int i = 63; i >= 0; i--)
        {
            boundary = (ulong)Math.Pow(2, i);
            if (boundary <= number)
            {
                Console.Write("1");
                number = number - boundary; 
                start = true;
            }
            else if (start)
            {
                Console.Write("0");                
            }
        }

        Console.WriteLine();
    }
}
