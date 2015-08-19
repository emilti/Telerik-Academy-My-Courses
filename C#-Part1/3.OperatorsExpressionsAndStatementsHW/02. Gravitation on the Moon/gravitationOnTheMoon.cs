using System;

// Problem 2. Gravitation on the Moon
//
//    The gravitational field of the Moon is approximately 17% of that on the Earth.
//    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
public class GravitationOnTheMoon
{
    public static void Main()
    {
        Console.WriteLine("Enter your weight on the Earth:");
        double weightOnEarth = double.Parse(Console.ReadLine());
        Console.WriteLine("Your weight on the Moon is:");
        double weightonMoon = weightOnEarth * 17 / 100;
        Console.WriteLine(weightonMoon);
    }
}