using Domain.Abstractions;
using Domain.Models;

namespace BDDTests
{
    public class InMemoryProductRepository : IProductRepository
    {
        private List<Product> _products;


        public void Init(IEnumerable<Product> products)
        {
            _products = products.ToList();
        }

        public Task<List<Product>> GetAllProducts()
        {
            return Task.FromResult(_products);
        }

        public Task<Product> GetProductById(Guid productId)
        {
            return Task.FromResult(_products.FirstOrDefault(p => p.ProductId == productId));
        }

        public async Task InsrestProduct(Product product)
        {
            Task.FromResult(0);
            _products.Add(product);
        }

        public async Task UpdateProdct(Product product)
        {
            Task.FromResult(0);
            var foundProduct = _products.FirstOrDefault(x => x.ProductId == product.ProductId);
            if (foundProduct != null) foundProduct = product;
        }
    }
}