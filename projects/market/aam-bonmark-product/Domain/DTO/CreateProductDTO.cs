using System;

namespace aam_bonmark_product.Domain.DTO
{
    public class CreateProductDTO
    {
        public String Name {get; set;}

        public CreateProductDTO(String Name){
            this.Name = Name;
        }

    }
}
