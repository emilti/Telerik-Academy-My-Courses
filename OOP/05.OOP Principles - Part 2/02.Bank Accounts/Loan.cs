namespace Accounts
{
    using System;

    public class Loan : Account, IDepositMoney
    {
        public Loan(string name, double balance, double interestRate, Customer holder, DateTime startDate) :
            base(name, balance, interestRate, holder, startDate)
        { 
        }        

        public double DepositMoney(double moneyToDeposit)
        {
            this.Balance = this.Balance + moneyToDeposit;
            return this.Balance;
        }

        public override double CalculateIntAmount()
        {
            TimeSpan period = DateTime.Now - StartDate;
            int months = period.Days / 30;
            if ((base.Holder.GetType() == typeof(Individual) && months <= 3)
                || (base.Holder.GetType() == typeof(Company) && months <= 2))
            {
                return 0;
            }
            else if (base.Holder.GetType() == typeof(Individual) && months > 3)
            {
                double interestAmount = this.Balance * (months - 3) * (this.InterestRate / 100);
                return interestAmount;
            }
            else
            {
                double interestAmount = this.Balance * (months - 2) * (this.InterestRate / 100);
                return interestAmount;
            }
        }

        public override string ToString()
        {
            return this.Name + " " + "Loan" + " " + this.Balance;
        }
    }
}
