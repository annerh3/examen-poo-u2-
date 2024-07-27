using Microsoft.EntityFrameworkCore;
using ProyectoExamenU2POO.Database.Entities;

namespace ProyectoExamenU2POO.Database
{
    public class ProyectoExamenContext : DbContext
    {
        public ProyectoExamenContext(DbContextOptions options) : base(options)
        {

        }

      
        public DbSet<PrestamoEntity> Prestamos { get; set; }
        public DbSet<PagoEntity> Pagos { get; set; }
        public DbSet<PrestamoPagoEntity> PrestamoPagos { get; set; }

    }
}
