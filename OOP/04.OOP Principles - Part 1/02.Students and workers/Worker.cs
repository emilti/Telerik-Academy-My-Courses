namespace StudentsAndWorkers
{
    public class Worker : Human
    {        
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary { get; private set; }

        public double WorkHoursPerDay { get; private set; }

        public double MoneyPerHour()
        {
            double moneyPerHour = this.WeekSalary / (this.WorkHoursPerDay * 5);
            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format("Worker {0} {1} week salary: {2}, work hours per day: {3}, money per hour: {4:0.00}", this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour());
        }
    }
}
