namespace Accounts
{
    using System;
    using System.Collections.Generic;

    public class MainProgram
    {
        public static void Main()
        {
            Deposit deposit1 = new Deposit("Az", 1200, 10, new Individual("Az"), new DateTime(2015, 1, 1));
            double depositIntAmount = deposit1.CalculateIntAmount();
            Loan loan1 = new Loan("Az", 2000, 10, new Company("Az"), new DateTime(2014, 10, 1));
            double loanIntAmount = loan1.CalculateIntAmount();
            Mortgage mortgage1 = new Mortgage("Az", 2000, 10, new Company("Az"), new DateTime(2014, 01, 1));
            double mortgageIntAmount = mortgage1.CalculateIntAmount();
            deposit1.DepositMoney(depositIntAmount);
            loan1.DepositMoney(loanIntAmount);
            mortgage1.DepositMoney(mortgageIntAmount);
            Console.WriteLine("The balance in the accounts after adding the interest:");
            IEnumerable<Account> collection = new List<Account>() { deposit1, loan1, mortgage1 };
            foreach (var acc in collection)
            {
                Console.WriteLine(acc);
            }    
        }
    }
}
