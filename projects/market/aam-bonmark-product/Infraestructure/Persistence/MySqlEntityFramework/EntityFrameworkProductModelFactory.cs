using Microsoft.EntityFrameworkCore;
using aam_bonmark_product.Domain;

namespace aam_bonmark_product.Infraestructure.Persistence.MySqlEntityFramework {
    public static class EntityFrameWorkProductModelFactory {

        public static void getEntityFrameworkProductModel(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
            });
        }
        
    }
}