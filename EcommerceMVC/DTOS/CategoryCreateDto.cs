using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.DTOS
{
    public class CategoryCreateDto
    {
        public int Id { get; set; }

        [Display(Name="Nombre")]
        [Required(ErrorMessage ="El valor es requerido")]
        public string Name { get; set; }
    }
}
