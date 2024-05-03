using Solid.ECommerceSystem.Entities;

namespace Solid.ECommerceSystem.Interfaces
{
    public interface IProductRepository
    {
        public void AddProduct(string name, decimal price, int quantity);
        public Product GetProductById(int id);
    }
}
