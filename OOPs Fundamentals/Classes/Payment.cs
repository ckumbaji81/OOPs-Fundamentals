using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOPs_Fundamentals.Classes
{
    public class Payment
    {
        public virtual void Process() { Console.Write("Processing Payment"); }
    }

    public class CreditCardPayment : Payment {
        public override void Process() { Console.Write("Processing credit card payment"); }
    }

    public class BankTransferPayment : Payment
    {
        public override void Process()
        {
            Console.Write("Processing bank transfer payment");
        }
    }

}