namespace StructuralPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainProgram
    {
        public static void Main()
        {
            Console.WriteLine("Chose Products (press 1, 2 or 3):" + "\n1.Cloathes" + "\n2.Shoes" + "\n3.Phone");
            CustomerService customerService = CustomerService.CreateInstance(int.Parse(Console.ReadLine()));           
            Products customerChoice = customerService.GetProduct(customerService.Product);
            customerService.GetBill(customerChoice);
        }
    }
}
