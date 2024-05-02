using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP
{
    //public class Account
    //{
    //    public decimal Balance { get; protected set; }
    //    public virtual  void Deposit(decimal amount)
    //    { Balance += amount;}
    //    public virtual  void Withdraw(decimal amount)
    //    {
    //        if (Balance >= amount)
    //        { Balance -= amount; }
    //        else
    //        {      throw new InvalidOperationException("Insufficient balance.");  }
    //    }
    //}
    //public class SavingsAccount : Account
    //{
    //    public decimal InterestRate { get; set; }
    //    public override void Withdraw(decimal amount)
    //    {
    //        amount += 5.0m;   //Impose a withdrawal fee
    //        base.Withdraw(amount);
    //    }
    //}


    
    // the SavingsAccount class violates the LSP because
    // it changes the behavior of the Withdraw method compared to its superclass Account.


    public abstract class Account
    {
        public decimal Balance { get;  set; }
        public  void Deposit(decimal amount)
        {  Balance += amount; }
        public  void Withdraw(decimal amount)
        {
            if (Balance >= (amount + withdrawal_fee())) 
                Balance -= (amount + withdrawal_fee());           
            else
               throw new InvalidOperationException("Insufficient balance.");
        }
        public abstract decimal withdrawal_fee();    
    }
    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; }
        public override decimal withdrawal_fee()
        { return 5; }
    }



}
