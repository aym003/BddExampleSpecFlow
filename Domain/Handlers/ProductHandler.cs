using Domain.Abstractions;
using Domain.Models;

namespace Domain.Handlers
{
    /// <summary>
    /// The Product Handler
    /// </summary>
    public class ProductHandler : IProductHandler
    {
        /// <summary>
        /// The Product Repo
        /// </summary>
        private readonly IProductRepository _repository;

        public ProductHandler(IProductRepository productRepository)
        {
            _repository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public async Task<IEnumerable<Product>> ProductsWithStock()
        {
            var products = await _repository.GetAllProducts();
            return products.Where(p => p.Stock > 0);
        }
    }
}
