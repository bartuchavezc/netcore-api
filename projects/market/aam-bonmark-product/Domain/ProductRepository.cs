using System;
using System.Collections.Generic;

namespace aam_bonmark_product.Domain
{
    public interface ProductRepository
    {
        List<Product> GetAll();

    }
}
