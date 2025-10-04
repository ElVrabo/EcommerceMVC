using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.DTOS
{
    public class BrandReadDto : RegistryDto
    {
        public int Id { get; set; }
        [Display(Name="Marca")]
        public string Name { get; set; }
        [Display(Name="Logo")]
        public string LogoUrl { get; set; }
    }
}
