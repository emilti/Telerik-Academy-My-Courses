using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EnterNumbers
{
    public static void Main()
    {
        Console.WriteLine("Enter the start and the end of the range:");
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int count = 0;
        while (count < 10)
        {
            int number = int.Parse(Console.ReadLine());
            bool isValid = ReadNumber(start, end, number);
            if (isValid == true)
            {
                count++;
            }
        }
    }

    public static bool ReadNumber(int start, int end, int number)
    {
        bool isValid = true;
        try
        {               
            Console.WriteLine("Enter number in the range {0} - {1}", start, end);
           
            if (number >= start && number <= end)
            {
                Console.WriteLine("{0} is in the range", number);                
            }
            else
            {
                throw new ArgumentOutOfRangeException("Number is out of range");                
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number");
            isValid = false;
        }       

        return isValid;       
    }
}