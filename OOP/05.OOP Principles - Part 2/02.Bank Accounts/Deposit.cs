namespace Accounts
{
    using System;

    public class Deposit : Account, IWithdrawMoney, IDepositMoney
    {
        public Deposit(string name, double balance, double interestRate, Customer holder, DateTime startDate) :
            base(name, balance, interestRate, holder, startDate)
        { 
        }

        public double WithdrawMoney(double moneyToWithdraw)
        {
            this.Balance = this.Balance - moneyToWithdraw;
            return this.Balance;
        }

        public double DepositMoney(double moneyToDeposit)
        {
            this.Balance = this.Balance + moneyToDeposit;
            return this.Balance;
        }

        public override double CalculateIntAmount()
        {
            TimeSpan period = DateTime.Now - StartDate;
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                double interestAmount = this.Balance * (period.Days / 30) * (this.InterestRate / 100);
                return interestAmount;
            }
        }

        public override string ToString()
        {
            return this.Name + " " + "Deposit" + " " + this.Balance;
        }
    }
}
