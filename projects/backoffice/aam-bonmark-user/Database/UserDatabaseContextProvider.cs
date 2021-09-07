using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace aam_bonmark_product.Database
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterUserDatabaseService(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MySQL_DATABASE_CONNECTION_STRING");
            services.AddDbContext<UserDatabaseContext>(builderOptions => builderOptions.UseMySql(
                    connectionString,
                    ServerVersion.AutoDetect(connectionString)
                ));
            return services;
        }
    }
}