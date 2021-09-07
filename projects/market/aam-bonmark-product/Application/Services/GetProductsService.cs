using aam_bonmark_product.Domain;
using System.Collections.Generic;

namespace aam_bonmark_product.Application.Services {
    public class GetProductsService
    {

        private readonly ProductRepository repository;
        public GetProductsService (ProductRepository repository){
            this.repository = repository;
        }
        public List<Product> GetAll()
        {
            return this.repository.GetAll();
        }
    }
}