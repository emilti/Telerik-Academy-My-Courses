namespace Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSMCallHistoryTest
    {   
        public static void GSMCallHistoryTestMethod()
        {
            List<Call> newRange = new List<Call>();

            // P12
            GSM phone3 = new GSM(
                "iPhone 4",
                "Apple",
                1200,
                "Doncho",
                new Battery("xxxx", 12, 3, BatteriesEnum.LiIon),
                new Display(12, 222),
                new List<Call>());
                var date1 = new DateTime(2014, 03, 10, 04, 55, 0);
                var date2 = new DateTime(2014, 03, 10, 13, 55, 0);
                var date3 = new DateTime(2014, 03, 10, 18, 55, 0);
            Call newcall1 = new Call(date1, "1234567890", 100);
            Call newcall2 = new Call(date2, "1234567890", 100);
            Call newcall3 = new Call(date3, "1234567890", 100);
            phone3.CallHistory.Add(newcall1);
            phone3.CallHistory.Add(newcall2);
            phone3.CallHistory.Add(newcall3);

            // P12
            phone3.AddCall();
            phone3.RemoveCall(phone3.CallHistory);
            phone3.PrintHistory();
            Console.WriteLine("Enter the price per minute:");
            double multi = double.Parse(Console.ReadLine());
            double totalSum = phone3.Calculate(multi);
            Console.WriteLine("Total sum for conversations:");
            Console.WriteLine(totalSum);
            int indexForRemoving = 0;
            double longestConversation = double.MinValue;
            for (int i = 0; i < phone3.CallHistory.Count; i++)
            {
                if (phone3.CallHistory[i].Duration > longestConversation)
                {
                    indexForRemoving = i;
                }
            }

            Console.WriteLine("Enter record {0} for removing (longest call in the list)", indexForRemoving);
            phone3.RemoveCall(phone3.CallHistory);
            double totalSumRecalc = phone3.Calculate(multi);
            Console.WriteLine("Total sum for conversations after removing the longest call:");
            Console.WriteLine(totalSumRecalc);
            phone3.PrintHistory();
            phone3.ClearAll();
        }
    }
}