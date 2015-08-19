using System;

// 9. Sum of n Numbers
//
//    Write a program that enters a number n and after that enters more n numbers and calculates and prints their 
public class SumOfnNumbers
{
    public static void Main()
    {
        Console.WriteLine("Enter the count of the numbers:");
        int countOfNumbers = int.Parse(Console.ReadLine());
        double sum = 0;
        Console.WriteLine("Enter the numbers:");
        for (int index = 0; index < countOfNumbers; index++)
        {
            double number = double.Parse(Console.ReadLine());
            sum = number + sum;
        }
        Console.WriteLine("Sum of the numbers is: {0}", sum);
    }
}