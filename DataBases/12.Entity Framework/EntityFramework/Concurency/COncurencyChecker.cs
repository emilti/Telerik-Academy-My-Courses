namespace Concurency
{
    using System.Linq;

    public class ConcurencyChecker
    {
        public static void Main()
        {
            NorthwindEntities dbNorthwnd = new NorthwindEntities();
            NorthwindTwinEntities dbNorthwndtwin = new NorthwindTwinEntities();
            
            var employee = dbNorthwnd.Employees.Where(z => z.EmployeeID == 1).First();
            employee.FirstName = "Gosho";
            var employeeTwin = dbNorthwndtwin.Employees.Where(z => z.EmployeeID == 1).First();
            employee.FirstName = "GoshoTwin";
            
            dbNorthwnd.SaveChanges();
            dbNorthwndtwin.SaveChanges();
        }
    }
}
