using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace aam_bonmark_product.Database
{
    public class ProductDatabaseContextFactory : IDesignTimeDbContextFactory<ProductDatabaseContext>
    {
        public ProductDatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProductDatabaseContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=test;Uid=test;Pwd=1234;", ServerVersion.AutoDetect("Server=localhost;Database=test;Uid=test;Pwd=1234;"));

            return new ProductDatabaseContext(optionsBuilder.Options);
        }
    }
}
