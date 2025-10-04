using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.DTOS
{
    public class CategoryReadDto : RegistryDto
    {
        [Display(Name = "Numero de categoria")]
        public int Id { get; set; }

        [Display(Name = "Nombre de la categoria")]
        public string Name { get; set; } = string.Empty;
       
    }
}
