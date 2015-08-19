using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TriangleSurface
{
    public static void Main()
    {
        Console.WriteLine("Choose option for calculation of the triangle surface:");
        bool isNot123 = true;
        int option = 0;
        while (isNot123)
        {
            Console.WriteLine("1---Side and an altitude to it");
            Console.WriteLine("2---Three sides");
            Console.WriteLine("3---Two sides and an angle between them");
            option = int.Parse(Console.ReadLine());
            if (option >= 1 && option <= 3)
            {
                isNot123 = false;
            }
            else
            {
                Console.WriteLine("Not number from 1 to 3. Please try again.");
            }
        }
        
        if (option == 1)
        {          
            double surface = GetSurfaceAltitude();
            Console.WriteLine("THe surface of the triangle is {0:F2}", surface);
        }
        else if (option == 2)
        {            
            double surface = GetSurfaceFromThreeSides();
            Console.WriteLine("THe surface of the triangle is {0:F2}", surface);
        }
        else if (option == 3)
        {
            double surface = GetSurfaceFromTwoSidesAngle();
            Console.WriteLine("THe surface of the triangle is {0:F2}", surface);
        }
    }

    public static double GetSurfaceAltitude()
    {
         Console.WriteLine("Option 1 - enter side and altitude:");
         Console.Write("Side a:");
         double side = double.Parse(Console.ReadLine());
         Console.Write("Altitude:");
         double altitude = double.Parse(Console.ReadLine());
         double surfaceAltitude = ((double)side * altitude) / 2;
         return surfaceAltitude;
    }

    public static double GetSurfaceFromThreeSides()
    {
        Console.WriteLine("Option 2 - enter three sides:");
        Console.Write("Side a:");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Side b:");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Side c:");
        double sideC = double.Parse(Console.ReadLine());  
        double halfPerimeter = (sideA + sideB + sideC) / (double)2;
        double surfaceThreeSides = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
        return surfaceThreeSides;
    }

    public static double GetSurfaceFromTwoSidesAngle()
    {
        Console.WriteLine("Option 3 - enter two side and an angle:");
        Console.Write("Side a:");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Side b:");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Angle in grad:");
        double angle = double.Parse(Console.ReadLine());
        double angleInRadians = angle * Math.PI / 180;       
        double surfaceTwoSidesAngle = (Math.Sin(angleInRadians) * sideA * sideB) / 2;
        return surfaceTwoSidesAngle;
    }
}