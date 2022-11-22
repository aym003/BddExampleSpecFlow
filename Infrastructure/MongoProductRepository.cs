using Domain.Abstractions;
using Domain.Models;

namespace Infrastructure
{
    public class MongoProductRepository : IProductRepository
    {
        public Task<List<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductById(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task InsrestProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProdct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
