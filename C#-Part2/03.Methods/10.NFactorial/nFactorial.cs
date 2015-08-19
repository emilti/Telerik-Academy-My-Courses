using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public class NFactorial
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        BigInteger factoriel = FactorielCalculation(number);
        Console.WriteLine("!n facktoriel from {0} is {1}", number, factoriel);
    }

    public static BigInteger FactorielCalculation(int number)
    {
        BigInteger product = 1;        
        for (int i = 2; i <= number; i++)
        {
            product *= i;
        }

        return product;
    }    
}