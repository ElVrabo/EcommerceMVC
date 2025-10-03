using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models
{
    //hereda de la clase Registry que contiene propiedades reutilizables en distintas entidades
    public class Category : Registry
    {
        
        public int Id { get; set; }

      
        public string Name { get; set; } = string.Empty;

        //Relacion uno a muchos, una categoria tiene varios productos
        public ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
