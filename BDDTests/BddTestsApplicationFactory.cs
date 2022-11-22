using Domain.Abstractions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace BDDTests
{
    public class BddTestsApplicationFactory : WebApplicationFactory<Program>
    {
        public readonly InMemoryProductRepository ProductRepository = new InMemoryProductRepository();

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddScoped<IProductRepository>(x =>
                {
                    return ProductRepository;
                }
                );
            });

            builder.UseEnvironment("Development");
        }
    }
}
