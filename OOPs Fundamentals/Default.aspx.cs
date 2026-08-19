using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OOPs_Fundamentals
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BankAccount account1 = new BankAccount("1", "John", 1000);
            BankAccount account2 = new BankAccount("2", "Mary", 500);

            account1.Withdraw(200);
            account2.Withdraw(500);

            Console.WriteLine("Balance of account1: " + account1.GetBalance().ToString());
            Console.WriteLine("Balance of account2: " + account2.GetBalance().ToString());

        }
    }
}