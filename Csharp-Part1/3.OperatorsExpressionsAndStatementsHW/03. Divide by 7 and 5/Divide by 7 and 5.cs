using System;

// Problem 3. Divide by 7 and 5
//
// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
public class Divide
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isDivided = false;
        if (number % 5 == 0 && number % 7 == 0)
        {
            isDivided = true;
            Console.WriteLine("The number can divided by 5 and 7: {0}", isDivided);
        }
        else
        {
            Console.WriteLine("The number can divided by 5 and 7: {0}", isDivided);
        }
    }
}