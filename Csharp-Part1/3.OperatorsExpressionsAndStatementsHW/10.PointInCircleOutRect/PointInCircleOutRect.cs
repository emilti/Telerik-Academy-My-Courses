using System;

// Problem 10. Point Inside a Circle & Outside of a Rectangle
public class PointInsACircleOtsRec
{
    public static void Main()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

        bool checkCircle = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= (1.5 * 1.5);
        bool checkRectangle = (x < -1 || x > 5) && (y < -1 || y > 1);

        if (x == 0 || y == 0)
        {
            Console.WriteLine("no");
        }
        else if (checkCircle == true && checkRectangle == true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}