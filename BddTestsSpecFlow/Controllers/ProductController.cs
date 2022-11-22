using Domain.Abstractions;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BddTestsSpecFlow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        /// <summary>
        /// The Product Handler
        /// </summary>
        private IProductHandler _productHandler;

        /// <summary>
        /// Controller Constructor
        /// </summary>
        /// <param name="productHandler">The ProductHandler</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ProductController(IProductHandler productHandler)
        {
            _productHandler = productHandler ?? throw new ArgumentNullException(nameof(productHandler));
        }

        [HttpGet("/ProductsWithStock")]
        public async Task<IEnumerable<Product>> ProductsWithStock()
        {
            return await _productHandler.ProductsWithStock();
        }
    }
}
