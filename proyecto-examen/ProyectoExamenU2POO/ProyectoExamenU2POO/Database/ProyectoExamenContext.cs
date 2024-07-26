using Microsoft.EntityFrameworkCore;

namespace ProyectoExamenU2POO.Database
{
    public class ProyectoExamenContext : DbContext
    {
        public ProyectoExamenContext(DbContextOptions options) : base(options)
        {
            
        }


      //  public DbSet<EntityName> TableName { get; set; } // esto representa una tabla en la base
    }
}
