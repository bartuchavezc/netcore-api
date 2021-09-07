using aam_bonmark_product.Application.Services;
using aam_bonmark_product.Domain;
using aam_bonmark_product.Infraestructure.Persistence.MySqlEntityFramework;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ProductServiceCollectionExtensions
    {

        public static IServiceCollection RegisterProductServices(this IServiceCollection services)
        {
            services.AddScoped<ProductRepository, EntityFrameworkProductRepository>();
            services.AddScoped<GetProductsService>();
            return services;
        }
    }
}