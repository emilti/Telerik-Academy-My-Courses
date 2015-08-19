using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SquareRoot
{
    public static void Main()
    {
        Console.WriteLine("Enter integer number");        
        try
        {
            uint number = uint.Parse(Console.ReadLine());           
            double result = Math.Sqrt(number);
            Console.WriteLine(result);
        }
        catch (Exception)
        {           
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }      
    }
}