namespace Solid.ECommerceSystem.Entities
{
    public class Order
    {
        public string CustomerName { get; set; }
        public decimal TotalCost { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
