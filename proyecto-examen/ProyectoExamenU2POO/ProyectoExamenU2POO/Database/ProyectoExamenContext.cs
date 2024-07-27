using Microsoft.EntityFrameworkCore;
using ProyectoExamenU2POO.Database.Entities;

namespace ProyectoExamenU2POO.Database
{
    public class ProyectoExamenContext : DbContext
    {
        public ProyectoExamenContext(DbContextOptions options) : base(options)
        {
            
        }


        public DbSet<ClienteEntity> Clientes { get; set; } // esto representa una tabla en la base
    }
}
