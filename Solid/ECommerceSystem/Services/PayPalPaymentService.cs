using Solid.ECommerceSystem.Interfaces;

namespace Solid.ECommerceSystem.Services
{
    public class PayPalPaymentService : IPaymentService
    {
        public void Payment(decimal amount)
        {
            // Process PayPal payment
            Console.WriteLine($"Processing PayPal payment of ${amount}");
        }
    }
}
