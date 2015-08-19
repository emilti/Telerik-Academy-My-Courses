namespace InvalidRangeException
{
    using System;
    using System.Globalization;
    using System.Text;

    public class TestEception
    {
        public static void Main()
        {
            Console.WriteLine("Enter number:");
            int testNumber = int.Parse(Console.ReadLine());
            if (testNumber < 1 || testNumber > 100)
            {
                throw new InvalidRangeException<int>("Inavlid range [{0}...{1}]", 1, 100);
            }

            Console.WriteLine("Enter date:");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime start = new DateTime(1980, 1, 1);
            DateTime end = new DateTime(2013, 12, 31);            
            if (date < start || date > end)
            {
                throw new InvalidRangeException<DateTime>("Inavlid range [{0}...{1}]", new DateTime(1983, 1, 1), new DateTime(2013, 31, 12));
            }
        }
    }
}
