namespace StructuralPatterns
{
    public abstract class EmployeeComponent
    {
        protected EmployeeComponent(string name)
        {
            this.Name = name;
        }

        protected string Name { get; private set; }

        public abstract void Add(EmployeeComponent empployee);

        public abstract void Remove(EmployeeComponent empployee);

        public abstract void Display(int depth);
    }
}
