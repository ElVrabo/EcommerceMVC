using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Data
{
    // Clase principal que se encarga de interactuar con la base de datos
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {

        }
    }
}
