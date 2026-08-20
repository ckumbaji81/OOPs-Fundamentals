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
        public decimal Balance
        {  get; 
           private set; 
        }

        public string Deposit(decimal amount)
        {
            if (amount < 0) return "Reject";

            Balance += amount;
            return "Success";
        }

        public string Withdraw(decimal amount)
        {
            if ((Balance <= 0 && amount > 0) || (amount < 0) || (Balance < amount)) return "reject";

            Balance -= amount;
            return "Success";
        }


        public BankAccount(string accountNum, string accountName, decimal bal)
        {
            this.accountNumber = accountNum;
            this.accountHolderName = accountName;
            this.Balance = bal;
        }

    }
}