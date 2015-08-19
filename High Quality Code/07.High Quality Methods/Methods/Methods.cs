namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");                
            }

            double halfOfThePerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfOfThePerimeter * (halfOfThePerimeter - a) * (halfOfThePerimeter - b) * (halfOfThePerimeter - c));
            return area;
        }

        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:
                    throw new ArgumentOutOfRangeException("Input must be between 0 and 9");
            }          
        }

        public static int FindMax(params int[] elements)
        {
            int maxValue = elements[0];
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("You need to pass an non empty array with int"); 
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxValue)
                {
                    maxValue = elements[i];
                }
            }

            return maxValue;
        }

        public static void PrintAsNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        public static void PrintAsAbsoluteNumber(object number)
        {            
                Console.WriteLine("{0:f2}", number);            
        }

        public static void PrintAsPercentage(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        public static void PrintAsRightAlignedNumber(object number)
        {
            Console.WriteLine("{0,8}", number);
        }            

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        public static void CheckHorizontal(double sideA, double sideC, out bool horizontal)
        {
            horizontal = false;            
            if (sideA == sideC)
            {
                horizontal = true;
            }          
        }

        public static void CheckVertical(double sideB, double sideD, out bool vertical)
        {          
            vertical = false;           
            if (sideB == sideD)
            {
                vertical = true;
            }
        }       
    }
}
