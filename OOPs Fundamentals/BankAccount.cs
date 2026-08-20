using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOPs_Fundamentals
{
    public class BankAccount
    {
        string accountNumber;
        string accountHolderName;
        decimal balance;

        public string Deposit(decimal amount)
        {
            if (amount < 0) return "Reject";

            balance += amount;
            return "Success";
        }

        public string Withdraw(decimal amount)
        {
            if ((balance <= 0 && amount > 0) || (amount < 0)) return "reject";

            balance -= amount;
            return "Success";
        }

        public decimal GetBalance()
        {
            return balance; 
        }

        public BankAccount(string accountNum, string accountName, decimal bal)
        {
            this.accountNumber = accountNum;
            this.accountHolderName = accountName;
            this.balance = bal;
        }

    }
}