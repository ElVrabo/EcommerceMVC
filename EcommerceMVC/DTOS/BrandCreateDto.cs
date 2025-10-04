using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.DTOS
{
    public class BrandCreateDto
    {
        public int Id { get; set; }
        [Display(Name="Marca")]
        [Required(ErrorMessage ="El nombre de la marca es requerida")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "   logo")]
        [Required(ErrorMessage = "El logo de la marca es requerida")]
        //Cuando es un archivo debe de ser de tipo IFormFile
        public IFormFile File { get; set; } 
    }
}
