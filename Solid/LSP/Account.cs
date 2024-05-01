using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP
{
    public class Account
    {
        public decimal Balance { get; protected set; }
        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public virtual void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient balance.");
            }
        }
    }


    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; }
        public override void Withdraw(decimal amount)
        {
            //Impose a withdrawal fee
                amount += 5.0m;
                base.Withdraw(amount);
        }
    }

    //The Liskov Substitution Principle(LSP) states that objects of a superclass should be replaceable with objects of 
    // a subclass without affecting the correctness of the program. ,the SavingsAccount class violates the LSP because
    // it changes the behavior of the Withdraw method compared to its superclass Account.

    public class WithdrawalFeeAccount : Account
    {
        public decimal WithdrawFee { get; set; }

        public WithdrawalFeeAccount(decimal withdrawalFee)
        {
            WithdrawFee = withdrawalFee;
        }

        public override void Withdraw(decimal amount)
        {
            if (Balance >= amount + WithdrawFee)
                Balance -= (amount + WithdrawFee);
            else
                throw new InvalidOperationException("Insufficient balance.");         
        }


    }

    public class LSPSavingsAccount : WithdrawalFeeAccount
    {
        public LSPSavingsAccount(decimal withdrawalFee) : base(withdrawalFee) { }
    }
}
