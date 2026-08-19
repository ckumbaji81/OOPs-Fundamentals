using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOPs_Fundamentals
{
    public class BankAccount
    {
        string AccountNumber;
        string AccountHolderName;
        decimal balance;

        public void Deposit(decimal Amount)
        {
            balance += Amount;
        }

        public void Withdraw(decimal Amount)
        {
            balance -= Amount;
        }

        public decimal GetBalance()
        {
            return balance; 
        }

        public BankAccount(string accountNumber, string accountHolderName, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            this.balance = balance;
        }

    }
}