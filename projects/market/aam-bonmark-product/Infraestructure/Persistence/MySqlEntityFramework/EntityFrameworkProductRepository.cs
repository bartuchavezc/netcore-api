using aam_bonmark_product.Domain;
using System.Collections.Generic;
using aam_bonmark_product.Database;
using System.Linq;

namespace aam_bonmark_product.Infraestructure.Persistence.MySqlEntityFramework {
    public class EntityFrameworkProductRepository : ProductRepository
    {

        private readonly ProductDatabaseContext _context;
        public EntityFrameworkProductRepository (ProductDatabaseContext context){
            _context = context;
        }
        public List<Product> GetAll()
        {
            return _context.Product.ToList();
        }
    }
}