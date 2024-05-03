using Solid.ECommerceSystem.Entities;

namespace Solid.ECommerceSystem.Interfaces
{
    public interface IEmailNotificationService
    {
        public void SendOrderConfirmationEmail(Order order);
    }
}
