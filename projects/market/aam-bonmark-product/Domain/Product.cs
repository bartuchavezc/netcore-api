using System;

namespace aam_bonmark_product.Domain
{
    public class Product
    {
        public int Id {get; set;}
        public String Name {get; set;}

        public Product(String Name){
            this.Name = Name;
        }

    }
}
