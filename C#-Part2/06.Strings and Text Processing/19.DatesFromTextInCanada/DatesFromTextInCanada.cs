using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class DatesFromTextInCanada
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Regex rgx = new Regex(@"[0-9]{2}\.[0-9]{2}\.[0-9]{4}\b", RegexOptions.None);

        var dates = rgx.Matches(input).OfType<Match>().Select(m => m.Groups[0].Value).ToArray();
        Console.WriteLine("The dates in the text are:");

        DateTime[] arrayOfDates = dates.Select(t => Convert.ToDateTime(t)).ToArray();
        foreach (var date in dates)
        {
            DateTime dateCanada;
            if (DateTime.TryParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateCanada))
            {
                Console.WriteLine(dateCanada.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}