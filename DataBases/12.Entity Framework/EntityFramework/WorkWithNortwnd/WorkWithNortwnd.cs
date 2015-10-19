namespace WorkWithNortwnd
{
    using System;
    using System.Linq;
    public class WorkWithNortwnd
    {
        public static void Main()
        {
            using (var dbNorthwnd = new NorthwindEntities())
            {
                // Task 2. Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers.
                // START JUST ONE TIME - otherwise throw exception, because it creates customers with the same id number.
                // ADO.AddCustomer(dbNorthwnd, "1");
                // ADO.AddCustomer(dbNorthwnd, "2");
                // ADO.ModifyCustomer(dbNorthwnd);
                // ADO.DeleteCustomer(dbNorthwnd);

                // Task 3. Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
                FindCustomersWithOrdersFrom1997ToCanada(dbNorthwnd);
                Console.WriteLine();

                // Task 4. Implement previous by using native SQL query and executing it through the DbContext.
                Console.WriteLine("Task 4");
                FindCustomersWithOrdersFrom1997ToCanadaWithNativeSQL(dbNorthwnd);
                Console.WriteLine();

                // Task 5. Write a method that finds all the sales by specified region and period (start / end dates).
                Console.WriteLine("Task 5");
                FindSalesByRegionAndPeriod(dbNorthwnd, "Canada", new DateTime(1996, 10, 10), new DateTime(1997, 10, 10));
            }
        }

        private static void FindSalesByRegionAndPeriod(NorthwindEntities dbNorthwnd, string country, DateTime startDate, DateTime endDate)
        {
            var sales = dbNorthwnd.Orders.Where(
                c => c.ShipCountry == country &&
                c.OrderDate >= startDate &&
                c.OrderDate <= endDate).ToList();

            foreach (var sale in sales)
            {
                Console.WriteLine(sale.OrderID);
            }
        }

        private static void FindCustomersWithOrdersFrom1997ToCanadaWithNativeSQL(NorthwindEntities dbNorthwnd)
        {
            string nativeSQLQuery =
                "SELECT * " +
                "FROM [Northwind].[dbo].[Customers] a " +
                "INNER JOIN [Northwind].[dbo].[Orders] b " +
                "on a.CustomerId = b.CustomerId " +
                "WHERE Country = 'Canada' and YEAR(b.OrderDate) = '1997'";
            var customers = dbNorthwnd.Database.SqlQuery<Customer>(nativeSQLQuery)
                    .ToList();
            foreach (var cust in customers)
            {
                Console.WriteLine(cust.ContactName);
            }
        }

        private static void FindCustomersWithOrdersFrom1997ToCanada(NorthwindEntities dbNorthwnd)
        {
            var customers = dbNorthwnd.Orders.Where(ord => ord.ShipCountry == "Canada" &&
                ord.OrderDate.Value.Year == 1997).ToList();
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerID + ' ' + customer.Customer.ContactName);
            }
        }
    }
}
