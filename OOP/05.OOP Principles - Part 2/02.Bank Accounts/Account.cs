namespace Accounts
{
    using System;

    public abstract class Account
    {
        private string name;
        private double balance;
        private double interestRate;
        private Customer holder;
        private DateTime startDate;       

        public Account(string name, double balance, double interestRate, Customer holder, DateTime startDate)
        {
            this.Name = name;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Holder = holder;
            this.StartDate = startDate;
        }        

        public string Name
        {
            get 
            { 
                return this.name; 
            }

            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name");
                }

                this.name = value; 
            }
        }

        public double Balance
        {
            get { return this.balance; }

            set { this.balance = value; }
        }

        public double InterestRate
        {
            get { return this.interestRate; }
            private set { this.interestRate = value; }
        }

        public Customer Holder
        {
            get 
            {
                return this.holder; 
            }

            private set 
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid name");
                }

                this.holder = value; 
            }
        }

        public DateTime StartDate
        {
            get 
            {
                return this.startDate; 
            }

            private set 
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid name");
                }

                this.startDate = value; 
            }
        }

        public abstract double CalculateIntAmount();        
    }
}