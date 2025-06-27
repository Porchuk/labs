using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class BankAccount
    {
        private string AccountNumber { get; set; }
        private double Balance { get; set; }

        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount > Balance) return false;
            Balance -= amount;
            return true;
        }

        public double GetBalance()
        {
            return Balance;
        }
    }



}
