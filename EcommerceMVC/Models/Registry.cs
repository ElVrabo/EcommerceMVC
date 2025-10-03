namespace EcommerceMVC.Models
{
    public class Registry
    {

        public bool Active { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime HighSystem { get; set; } = DateTime.Now;
    }
}
