using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithNortwnd
{
    public static class ADO
    {
        public static void AddCustomer(NorthwindEntities dbNorthwnd, string name)
        {
            var customer = new Customer()
            {
                CustomerID = "AAAA" + name,
                CompanyName = "YYYY" + name,
                ContactName = "Pesho Peshev",
                ContactTitle = "Shef",
                Address = "aaaaaaaaaa",
                City = "Sofia",
                PostalCode = "1330",
                Country = "Bulgaria",
                Phone = "0000000",
                Fax = "0000000"
            };
            dbNorthwnd.Customers.Add(customer);
            try
            {
                dbNorthwnd.SaveChanges();
            }
            catch (Exception ex)
            {
           
            }
        }

        public static void ModifyCustomer(NorthwindEntities dbNorthwnd)
        {
            var customer = dbNorthwnd.Customers.Where(z => z.CustomerID == "AAAA1").First();
            customer.ContactName = "Gosho Goshev";
            dbNorthwnd.SaveChanges();
        }

        public static void DeleteCustomer(NorthwindEntities dbNorthwnd)
        {
            var customer = dbNorthwnd.Customers.Where(z => z.CustomerID == "AAAA1").First();
            dbNorthwnd.Customers.Remove(customer);
            var affectedRows = dbNorthwnd.SaveChanges();
            Console.WriteLine("({0} row(s) affected)", affectedRows);
        }
    }
}
