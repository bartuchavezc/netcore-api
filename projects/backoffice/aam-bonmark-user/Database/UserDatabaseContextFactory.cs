using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace aam_bonmark_product.Database
{
    public class UserDatabaseContextFactory : IDesignTimeDbContextFactory<UserDatabaseContext>
    {
        public UserDatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UserDatabaseContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=test;Uid=test;Pwd=1234;", ServerVersion.AutoDetect("Server=localhost;Database=test;Uid=test;Pwd=1234;"));

            return new UserDatabaseContext(optionsBuilder.Options);
        }
    }
}
