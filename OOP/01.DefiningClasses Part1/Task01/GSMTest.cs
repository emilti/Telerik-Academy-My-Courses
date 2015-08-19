namespace Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Task;

    public class GSMTest
    {
        // P7
        public static void Main()
        {
            GSMTestMethod();
            GSMCallHistoryTest.GSMCallHistoryTestMethod();
        }

        private static void GSMTestMethod()
        {
            GSM phone1 = new GSM(
                "iPhone 4", 
                "Apple", 
                1000, 
                "Pesho",
                new Battery("zzzz", 10, 2, BatteriesEnum.LiIon), 
                new Display(12, 222), 
                new List<Call>());
            GSM phone2 = new GSM(
                "iPhone 3",
                "Apple", 
                500,
                "Gosho",
                new Battery("yyyy", 12, 1, BatteriesEnum.NiCd),
                new Display(14, 224),
                new List<Call>());
           
            GSM[] allPhones = { phone1, phone2 };
            foreach (var gsm in allPhones)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}