using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PrimeNumbers
{   
    public static void Main()
    {
        List<int> listOfNotPrimes = new List<int>();
        List<int> listOfPrimes = new List<int>();
        StringBuilder sb = new StringBuilder();
        
        // StreamWriter streamWriter = new StreamWriter(@"D:\Telerik\Telerik-Academy\Csharp-Part2\01.Arrays\15.Task\test.txt");
        for (int i = 2; i < 10000; i++)
        {          
            for (int j = i; j < 10000; j++)
            {
                if (listOfNotPrimes.Contains(i))
                {
                    break;
                }

                if (j * i > 10000)
                {
                    break;
                }   
           
                listOfNotPrimes.Add(j * i);
            }

            if (!listOfNotPrimes.Contains(i))
            {
                sb.Append(i + " ");

                // listOfPrimes.Add(i);                
            }
        }

        Console.WriteLine(sb.ToString());

        // for (int k = 0; k < listOfPrimes.Count; k++)
        //  {
        //    Console.WriteLine(string.Join((", "),listOfPrimes));
        // }
    }
}

// Second solution 
// class SieveOfEratosthenes
// {
//     static void Main()
//     {
//         bool[] primes = new bool[10000000];
//         // Find all prime numbers in the range [1...10 000 000]
//         for (int i = 2; i < Math.Sqrt(primes.Length); i++)
//         {
//             // Skip those that are not prime
//             if (primes[i] == false)
//             {
//                 for (int j = i * i; j < primes.Length; j += i)
//                 {
//                     primes[j] = true;
//                 }
//             }
//         }
//         // Print all prime numbers in the range [1...10 000 000]
//         for (int i = 2; i < primes.Length; i++)
//         {
//             if (!primes[i]) Console.Write(i + " ");
//         }
//     }
// }
