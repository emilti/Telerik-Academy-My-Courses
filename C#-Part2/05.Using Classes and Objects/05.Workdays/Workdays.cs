using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Workdays
{
    public static void Main()
    {
       Console.WriteLine("Enter day in the future:");
       DateTime givenDate = DateTime.Parse(Console.ReadLine());        
       DateTime[] holidays = new DateTime[12];
       holidays[0] = new DateTime(2015, 3, 2);
       holidays[1] = new DateTime(2015, 3, 3);
       holidays[2] = new DateTime(2015, 4, 10);
       holidays[3] = new DateTime(2015, 4, 13);
       holidays[4] = new DateTime(2015, 5, 1);
       holidays[5] = new DateTime(2015, 5, 6);
       holidays[7] = new DateTime(2015, 9, 21);
       holidays[8] = new DateTime(2015, 9, 22);
       holidays[9] = new DateTime(2015, 12, 24);
       holidays[10] = new DateTime(2015, 12, 25);
       holidays[11] = new DateTime(2015, 12, 31);
       int numberOfWorkdays = GetWorkdaysCount(givenDate, holidays);
       Console.WriteLine("Working days until the given day in the future:");
       Console.WriteLine(numberOfWorkdays);
    }

    public static int GetWorkdaysCount(DateTime datePeriodEnd, DateTime[] holidays)
    {      
        DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
        DateTime start = now;
        int days = 0;
        while (start <= datePeriodEnd)
        {
            if (start.DayOfWeek != DayOfWeek.Saturday && start.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(start))
            {
                ++days;
            }

            start = start.AddDays(1);
        }

        return days;
    }
}