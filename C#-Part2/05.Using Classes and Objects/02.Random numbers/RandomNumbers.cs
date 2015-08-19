using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RandomNumbers
{
    public static void Main()
    {
        Random randomGen = new Random();
        for (int i = 0; i < 20; i++)
        {
           int ramdomNumber = randomGen.Next(100, 201);
           Console.WriteLine(ramdomNumber);
        }
    }
}