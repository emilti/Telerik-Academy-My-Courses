namespace Methods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestMethods
    {
        private static void Main()
        {
            Console.WriteLine(Methods.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.NumberToDigit(5));

            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Methods.PrintAsAbsoluteNumber(1.3);
            Methods.PrintAsPercentage(0.75);
            Methods.PrintAsRightAlignedNumber(2.30);

            bool horizontal, vertical;
            double sideA = 3;
            double sideB = -1;
            double sideC = 3;
            double sideD = 2.5;
            Console.WriteLine(Methods.CalcDistance(sideA, sideB, sideC, sideD));
            Methods.CheckHorizontal(sideA, sideC, out horizontal);
            Methods.CheckVertical(sideB, sideD, out vertical);
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov", OtherInfo = "From Sofia", BirthDate = new DateTime(1992, 3, 17) };

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova", OtherInfo = "From Vidin, gamer, high results", BirthDate = new DateTime(1993, 3, 11) };
            
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }     
    }
}
