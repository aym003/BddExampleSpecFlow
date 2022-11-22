using Domain.Models;

namespace Domain.Abstractions
{
    /// <summary>
    /// The Product Repository Interface
    /// </summary>
    public interface IProductRepository
    {
        /// <summary>
        /// Gets a product by id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Task<Product> GetProductById(Guid productId);

        /// <summary>
        /// Gets a list of all products
        /// </summary>
        /// <returns></returns>
        Task<List<Product>> GetAllProducts();

        /// <summary>
        /// Inserts a product
        /// </summary>
        /// <param name="product"></param>
        Task InsrestProduct(Product product);

        /// <summary>
        /// Updates a prodcut
        /// </summary>
        /// <param name="product"></param>
        Task UpdateProdct(Product product);
    }
}
