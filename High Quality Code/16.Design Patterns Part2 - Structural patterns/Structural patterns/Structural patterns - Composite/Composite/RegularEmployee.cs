namespace StructuralPatterns
{
    using System;

    public class RegularEmployee : EmployeeComponent
    {
        public RegularEmployee(string name)
            : base(name)
        {
        }

        public override void Add(EmployeeComponent employeeComponent)
        {
            Console.WriteLine("Cannot add to a person");
        }

        public override void Remove(EmployeeComponent employeeComponent)
        {
            Console.WriteLine("Cannot remove from a person");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name);
        }
    }
}