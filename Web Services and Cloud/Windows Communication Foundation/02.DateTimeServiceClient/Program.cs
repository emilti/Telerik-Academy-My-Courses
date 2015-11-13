using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DateTimeServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MyService.DateTimeServiceClient();
            string result = client.GetDayOfWeekInBulgarian(new DateTime(2015, 11, 12));
            Console.OutputEncoding = System.Text.Encoding.GetEncoding("Cyrillic");
            Console.InputEncoding = System.Text.Encoding.GetEncoding("Cyrillic");
            Console.WriteLine(result);
        }
    }
}
