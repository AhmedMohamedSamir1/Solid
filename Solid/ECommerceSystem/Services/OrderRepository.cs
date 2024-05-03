using Solid.ECommerceSystem.Entities;
using Solid.ECommerceSystem.Interfaces;

namespace Solid.ECommerceSystem.Services
{
    public class OrderRepository : IOrderRepository
    {
        private IPaymentService _paymentService;
        private IEmailNotificationService _notificationService;
        private readonly ProductRepository _productRepository;

        private List<Order> orders = new List<Order>();

        public OrderRepository(IPaymentService paymentService, IEmailNotificationService notificationService, ProductRepository productRepository)
        {
            _paymentService = paymentService;
            _notificationService = notificationService;
            _productRepository = productRepository;
        }
        public void PlaceOrder(string customerName, List<int> productIds, string paymentMethod)
        {
            decimal totalCost = 0;
            List<Product> orderedProducts = new List<Product>();
            foreach (int productId in productIds)
            {
                Product product = _productRepository.GetProductById(productId);
                if (product != null && product.Quantity > 0)
                {
                    orderedProducts.Add(product);
                    totalCost += product.Price;
                    product.Quantity--;
                }
            }

            if (orderedProducts.Count > 0)
            {
                switch (paymentMethod)
                {
                    case "CreditCard":
                        _paymentService = new CreditCardPaymentService();
                        _paymentService.Payment(totalCost);
                        break;
                    case "PayPal":
                        _paymentService = new PayPalPaymentService();
                        _paymentService.Payment(totalCost);
                        break;
                    default:
                        throw new ArgumentException("Invalid payment method");
                }


                Order order = new Order
                {
                    CustomerName = customerName,
                    Products = orderedProducts,
                    TotalCost = totalCost
                };

                _notificationService = new EmailNotificationService();
                _notificationService.SendOrderConfirmationEmail(order);
            }
        }
    }
}
