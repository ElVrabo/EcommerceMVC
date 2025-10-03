namespace EcommerceMVC.Models
{
    public class Brand : Registry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
