using Microsoft.EntityFrameworkCore;

namespace clase4590_ejemploAPI.Models
{
    public class ProductosCRUDContext : DbContext
    {
        public ProductosCRUDContext(DbContextOptions<ProductosCRUDContext> options) : base(options)
        {
        }


        public DbSet<Producto> Producto { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            //EL NOMBRE DE CADA PRODUCTO SEA UNICO
            modelBuilder.Entity<Producto>().HasIndex(c => c.Nombre).IsUnique();
        }
    }

    


}
