using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMVC.Models
{
    public class Product : Registry
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        [Column(TypeName ="decimal(10,2)")]
        public int Price { get; set; } 

        //Description puede ser valor nulo
        public string? Description { get; set; } = string.Empty;

        //Un Producto esta asociado a una categoria
        public int CategoryId { get; set; }

        public int BrandId { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
    }
}
