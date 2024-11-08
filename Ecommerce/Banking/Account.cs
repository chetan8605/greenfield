using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegation;

namespace Banking
{
    public class Account
    {
        public event Operation UnderBalance;
        public event Operation OverBalance;
        public double Balance { get; set; }
        public Account(double intialAmount)
        {
            Balance = intialAmount;
        }
        public void Withdraw(double amount)
        {
            double result = Balance - amount;
            if (result <= 10000)
            {
                Console.WriteLine("Less Balance");
                UnderBalance(5);
                // raise event : Insuficient Funds
            }
            Balance = result;
            // this.Balance = balance;
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
            if (Balance < 250000)
            {
                OverBalance(10);
                // raise event : Overbalance}
            }
        }
    }
}

    
