namespace Accounts
{
    using System;

    public class Mortgage : Account, IDepositMoney
    {
        public Mortgage(string name, double balance, double interestRate, Customer holder, DateTime startDate) :
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
            if (base.Holder.GetType() == typeof(Company))
            {
                double interestAmount;
                if (months <= 12)
                {
                    interestAmount = this.Balance * months * (this.InterestRate / (2 * 100));
                    return interestAmount;
                }
                else
                {
                    interestAmount = (this.Balance * 12 * (this.InterestRate / (2 * 100))) +
                        (this.Balance * (months - 12) * (this.InterestRate / 100));
                    return interestAmount;
                }
            }
            else if (base.Holder.GetType() == typeof(Company) && months <= 6)
            {
                return 0;
            }
            else
            {
                double interestAmount = this.Balance * (months - 6) * (this.InterestRate / 100);
                return interestAmount;
            }
        }

        public override string ToString()
        {
            return this.Name + " " + "Mortgage" + " " + this.Balance;
        }
    }
}
