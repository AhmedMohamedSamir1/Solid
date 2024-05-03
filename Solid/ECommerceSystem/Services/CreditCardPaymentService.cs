using Solid.ECommerceSystem.Interfaces;

namespace Solid.ECommerceSystem.Services
{
    public class CreditCardPaymentService : IPaymentService
    {
        public void Payment(decimal amount)
        {
            // Process credit card payment
            Console.WriteLine($"Processing credit card payment of ${amount}");
        }
    }
}
