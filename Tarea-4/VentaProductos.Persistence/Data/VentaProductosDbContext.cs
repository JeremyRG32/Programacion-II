using Microsoft.EntityFrameworkCore;
using VentaProductos.Domain;

namespace VentaProductos.Persistence.Data
{
    public class VentaProductosDbContext : DbContext
    {
        public VentaProductosDbContext(DbContextOptions<VentaProductosDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
