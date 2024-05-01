using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP
{
    public class PaymentProcessor
    {
        public void ProcessPayment(PaymentType type, double amount)
        {
            switch (type)
            {
                case PaymentType.CreditCard:
                    //Process credit card payment
                    break;
                case PaymentType.PayPal:
                    //Process PayPal payment
                    break;
                case PaymentType.BankTransfer:
                    //Process bank transfer payment
                    break;
                    //Add more cases for other payment types
            }
        }
    }
    public enum PaymentType
    {
        CreditCard,
        PayPal,
        BankTransfer
    }

    //----------------- the refactoring is ------------------------------------------------
    public abstract class PaymentMethod
    {
        public abstract void process(double amount);
    }

    public class CriditCard : PaymentMethod
    {
        public override void process(double amount)
        {
            Console.WriteLine("CriditCard process");
        }
    }

    public class PayPal : PaymentMethod
    {
        public override void process(double amount)
        {
            Console.WriteLine("PayPal process");
        }
    }

    public class BankTransfer : PaymentMethod
    {
        public override void process(double amount)
        {
            Console.WriteLine("BankTransfer process");
        }
    }

    public class OCPPaymentProcessor
    {
        public void ProcessPayment(PaymentMethod type, double amount)
        {
            type.process(amount);
        }
    }
}
