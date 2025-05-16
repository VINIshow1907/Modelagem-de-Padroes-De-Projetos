using Ecommerce.Data.Builders;
using Ecommerce.Objects.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace Ecommerce.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Pedido> Pedido { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            PedidoBuilder.Build(modelBuilder);

        }
    }
}