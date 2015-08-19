using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DayOfWeek
{
    public static void Main()
    {
        Console.WriteLine("Today is:");
        DateTime now = DateTime.Now;
        Console.WriteLine(now.DayOfWeek);
    }
}