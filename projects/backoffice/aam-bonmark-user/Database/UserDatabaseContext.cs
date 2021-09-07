using aam_bonmark_user.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace aam_bonmark_product.Database
{
    public partial class UserDatabaseContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public UserDatabaseContext()
        {
        }

        public UserDatabaseContext(DbContextOptions<UserDatabaseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Fullname).IsRequired();
            });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
