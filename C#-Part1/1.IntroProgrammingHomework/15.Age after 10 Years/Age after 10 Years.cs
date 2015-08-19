using System;

public class CurrentDateAndTime
{
    public static void Main()
    {
        Console.WriteLine("Your birth date:");
        string input = Console.ReadLine();
        DateTime birthDate = DateTime.Parse(input);
        int age = DateTime.Now.Year - birthDate.Year - (DateTime.Now.DayOfYear < birthDate.DayOfYear ? 1 : 0);
        Console.WriteLine("Current age {0}", age);
        Console.WriteLine("Age after 10 years: {0}", age + 10);
    }
}