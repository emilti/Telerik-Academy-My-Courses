using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class MainProgram
    {
        public static void Main()
        {
            // Task 8
            using (var dbNorthwnd = new NorthwindEntities())
            {
                EntityChild entity = new EntityChild();
                var employees = dbNorthwnd.Employees.ToList();
                foreach (var employee in employees)
                {
                    foreach (var teritory in employee.Territories)
                    {
                        Console.WriteLine(teritory.TerritoryDescription);
                    }
                }
            }
        }
    }
}
