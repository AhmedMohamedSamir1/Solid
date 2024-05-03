using Solid.ECommerceSystem.Entities;
using Solid.ECommerceSystem.Interfaces;

namespace Solid.ECommerceSystem.Services
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();
        public void AddProduct(string name, decimal price, int quantity)
        {
            products.Add(new Product
            {
                Name = name,
                Price = price,
                Quantity = quantity
            });
        }

        public Product GetProductById(int id)
        {
            return products.Find(p => p.Id == id);
        }
    }
}
