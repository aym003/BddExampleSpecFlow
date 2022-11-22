using Domain.Models;

namespace Domain.Abstractions
{
    public interface IProductHandler
    {
        Task<IEnumerable<Product>> ProductsWithStock();
    }
}
