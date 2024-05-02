using Solid.LSP;
namespace Solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            SavingsAccount account = new SavingsAccount();
            account.Balance = 1000;

            account.Withdraw(100);
            Console.WriteLine(account.Balance);
        }
    }
}
