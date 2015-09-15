namespace StructuralPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Billing
    {
        public int GetBill(Products choosenProduct)         
        {           
            if (choosenProduct == Products.Cloathes)
            {
                Console.WriteLine("Your bill is 10 dollars.");
                return 10;
            } 
            else if (choosenProduct == Products.Phone)
            {
                Console.WriteLine("Your bill is 15 dollars.");
                return 15;
            }
            else if (choosenProduct == Products.Shoes)
            {
                Console.WriteLine("Your bill is 5 dollars.");
                return 5;
            } 
            else
            {
                Console.WriteLine("Your don't have any bill to pay.");
                return 0;
            }
        }
    }
}