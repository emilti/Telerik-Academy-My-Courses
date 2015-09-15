namespace StructuralPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ChiefExecutive : EmployeeComponent
    {
        private readonly ICollection<EmployeeComponent> subjects;
        public ChiefExecutive(string name)
            : base(name)
        {
            this.subjects = new List<EmployeeComponent>();
        }

        public override void Add(EmployeeComponent person)
        {
            this.subjects.Add(person);
        }

        public override void Remove(EmployeeComponent person)
        {
            this.subjects.Remove(person);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name);

            foreach (var person in this.subjects)
            {
                person.Display(depth + 4);
            }
        }
    }
}
