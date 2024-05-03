namespace Solid.ECommerceSystem.Interfaces
{
    public interface IOrderRepository
    {
        public void PlaceOrder(string customerName, List<int> productIds, string paymentMethod);
    }
}
