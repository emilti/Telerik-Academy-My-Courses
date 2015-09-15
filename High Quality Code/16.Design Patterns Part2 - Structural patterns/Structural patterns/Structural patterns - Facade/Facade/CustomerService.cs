namespace StructuralPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Facade - contacting with the classes Billing, Query and Shippin
    /// </summary>    
    public class CustomerService
    {        
        private ClientQuery query = new ClientQuery();
        private Billing bill = new Billing();  
        
        protected CustomerService(int product)
        {
            this.Product = product;
        }

        public int Product { get; set; }

        public static CustomerService CreateInstance(int product)
        {
            return new CustomerService(product);
        }

        public Products GetProduct(int product) 
        {
            return this.query.ChooseProduct(product);
        }

        public int GetBill(Products product)
        {
            return this.bill.GetBill(product);
        }  
    }
}
