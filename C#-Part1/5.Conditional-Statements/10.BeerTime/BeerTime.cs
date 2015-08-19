using System;

public class BeerTime
{
    public static void Main()
    {
        DateTime time;
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");
        time = DateTime.Parse(Console.ReadLine());
        if (time >= startTime || time < endTime)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}