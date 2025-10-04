using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.DTOS
{

    //Un DTO es una clase que se usa como puente entre la vista/controlador y la entidad
    //real, ayuda a no exponer directamente la entidad de base de datos
    public class RegistryDto
    {
        
        //Este campo podra ser consumida por la vista (index) a traves de su propiedad Name
        [Display(Name ="Estatus")]
        public bool Active { get; set; }

        [Display(Name = "Fecha alta")]

        public DateTime HighSystem { get; set; } = DateTime.Now;
    }
}
