using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using WebApplication2.Models;

namespace ProductosCRUD.Server.Models
{
    public class ProductosCRUDContext : DbContext
    {
        public ProductosCRUDContext(DbContextOptions<ProductosCRUDContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            //EL NOMBRE DE CADA PRODUCTO SEA UNICO
            modelBuilder.Entity<Producto>().HasIndex(c => c.Nombre).IsUnique();
        }
    }
}
