using System;

public class OddandEvenProduct
{
    public static void Main()
    {
        Console.WriteLine("Enter a sequence of numbers:");
        string numbers = Console.ReadLine();
        string[] words = numbers.Split(' ');
        int n = words.Length;
        int[] newNumbers = new int[n];
        int oddProduct = 1;
        int evenProduct = 1;
        for (int a = 0; a < n; a++)
        {
            bool result = int.TryParse(words[a], out newNumbers[a]);
            if (result)
            {
                if ((a + 1) % 2 > 0)
                {
                    oddProduct = oddProduct * newNumbers[a];
                }
                else
                {
                    evenProduct = evenProduct * newNumbers[a];
                }
            }
            else
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.", words[a] == null ? "<null>" : words[a]);
            }
        }

        if (oddProduct - evenProduct == 0)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Porduct={0}", oddProduct);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Odd product={0}", oddProduct);
            Console.WriteLine("Even product={0}", evenProduct);
        }
    }
}