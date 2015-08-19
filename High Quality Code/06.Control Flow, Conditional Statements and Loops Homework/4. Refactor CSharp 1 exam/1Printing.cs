namespace RefactorExam1
{
using System;

    public class Task01
    {
        public const int SheetsInReam = 500;

        public static void Main()
        {
            int students = int.Parse(Console.ReadLine());
            int sheetsPerStudent = int.Parse(Console.ReadLine());
            double priceOfReam = double.Parse(Console.ReadLine());
            int totalSheets = students * sheetsPerStudent;
            double numberOfReams = (double)totalSheets / SheetsInReam;
            double totalCost = numberOfReams * priceOfReam;
            Console.WriteLine("{0:F2}", totalCost);
        }
    }
}
