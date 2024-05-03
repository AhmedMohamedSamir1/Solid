using Solid.ECommerceSystem.Entities;
using Solid.ECommerceSystem.Interfaces;

namespace Solid.ECommerceSystem.Services
{
    public class EmailNotificationService : IEmailNotificationService
    {
        public void SendOrderConfirmationEmail(Order order)
        {
            string message = $"Order confirmation for {order.CustomerName}:\n";
            message += $"Total Cost: ${order.TotalCost}\n";
            message += "Products:\n";
            foreach (Product product in order.Products)
            {
                message += $"- {product.Name} (${product.Price})\n";
            }
            // Send email
            Console.WriteLine(message);
        }
    }
}
