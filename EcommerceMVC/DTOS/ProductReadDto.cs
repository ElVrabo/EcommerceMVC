using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.DTOS
{
    public class ProductReadDto : RegistryDto
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Precio")]
       

        public int Price { get; set; }
        [Display(Name = "Descripcion")]


        //Description puede ser valor nulo
        public string? Description { get; set; } = string.Empty;
        
        public int CategoryId { get; set; }
        public int BrandId { get; set; }

        [Display(Name="Categoria")]
        public string Category { get; set; } = string.Empty;

        [Display(Name = "Categoria")]
        public string Brand { get; set; } = string.Empty;
    }
}
