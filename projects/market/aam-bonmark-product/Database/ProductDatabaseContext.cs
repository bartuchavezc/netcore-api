using Microsoft.EntityFrameworkCore;
using aam_bonmark_product.Infraestructure.Persistence.MySqlEntityFramework;
using aam_bonmark_product.Domain;

namespace aam_bonmark_product.Database
{
    public partial class ProductDatabaseContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public ProductDatabaseContext()
        {
        }

        public ProductDatabaseContext(DbContextOptions<ProductDatabaseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
            EntityFrameWorkProductModelFactory.getEntityFrameworkProductModel(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
