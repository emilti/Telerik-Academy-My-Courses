namespace StructuralPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ClientQuery
    {       
        public Products ChooseProduct(int choice)
        {           
            switch (choice)
            {
                case 1: Console.WriteLine("Product is: " + Products.Cloathes);
                    return Products.Cloathes;
                case 2: Console.WriteLine("Product is: " + Products.Shoes);
                    return Products.Shoes;
                case 3: Console.WriteLine("Product is: " + Products.Phone);
                    return Products.Phone;
                default: return Products.Nothing;
            }          
        }        
    }
}
