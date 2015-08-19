namespace Task0304
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OrderCheck
    {
        public static void Main()
        {
            var students = new Student[] 
            {
               new Student("Pesho", "Ivanov", 22),
               new Student("Atanas", "Georgiev", 21),
               new Student("Stefan", "Atanasov", 25),
               new Student("Anton", "Atanasov", 18),
               new Student("Anton", "Petrov", 22),
               new Student("Dimitar", "Penev", 24)
            };

            // Problem 3
            // var namesFiltered = students.Where(st => st.FirstName.CompareTo(st.LastName)<=0).ToList();
            var namesFiltered = from st in students
                                where st.FirstName.CompareTo(st.LastName) <= 0                               
                                select st;   
            Console.WriteLine("All students whose first name is before its last name alphabetically:");
            Console.WriteLine(string.Join(", ", namesFiltered));
            Console.WriteLine();
            
            // Problem 4
            // var ageFiltered = students.Where(st => st.Age >= 18 && st.Age <= 24).ToList();
            var ageFiltered = from st in students
                                where st.Age >= 18 && st.Age <= 24 
                                select st;
            
            Console.WriteLine("All students with age between 18 and 24.");
            Console.WriteLine(string.Join(", ", ageFiltered));
            Console.WriteLine();

            // problem 5
            var sortedByNameLambda = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);            
            Console.WriteLine("Sort the students by first name and last name in descending order:");
            Console.WriteLine(string.Join(", ", sortedByNameLambda));
            Console.WriteLine();
            var sortedByNameLINQ = from st in students
                          orderby st.FirstName descending, st.LastName descending
                          select st;
            Console.WriteLine("Sort the students by first name and last name in descending order:");
            Console.WriteLine(string.Join(", ", sortedByNameLINQ));
            Console.WriteLine();
        }
    }
}