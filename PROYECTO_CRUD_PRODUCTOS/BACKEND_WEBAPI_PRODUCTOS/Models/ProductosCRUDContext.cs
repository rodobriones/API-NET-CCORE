using Microsoft.EntityFrameworkCore;

namespace BACKEND_WEBAPI_PRODUCTOS.Models
{
    public class ProductosCRUDContext : DbContext
    {
        public ProductosCRUDContext(DbContextOptions<ProductosCRUDContext> options) : base(options)
        {
        
        }
                public DbSet <Producto>productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            //EL NOMBRE DE CADA PRODUCTO SEA UNICO
            modelBuilder.Entity<Producto>().HasIndex(c => c.nombre).IsUnique();
        }



    }
}
