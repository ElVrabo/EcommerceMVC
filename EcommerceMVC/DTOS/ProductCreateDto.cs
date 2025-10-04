using EcommerceMVC.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMVC.DTOS
{
    public class ProductCreateDto
    {
        public int Id { get; set; }
        [Display(Name="Nombre")]
        [Required(ErrorMessage ="El nombre del producto es requerido")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El nombre del producto es requerido")]
        [Range(0.01,double.MaxValue, ErrorMessage ="El precio debe ser mayor que 0")]

        public int Price { get; set; }
        [Display(Name = "Descripcion")]
        

        //Description puede ser valor nulo
        public string? Description { get; set; } = string.Empty;

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Debe seleccionar una categoria")]
        public int CategoryId { get; set; }

        [Display(Name = "Marca")]
        [Required(ErrorMessage = "Debe seleccionar una marca")]
        public int BrandId { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
    }
}
