using Ecommerce.Objects.Enums;
using Ecommerce.Objects.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Threading;

namespace Ecommerce.Data.Builders
{
    public class PedidoBuilder
    {
        public static void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>().HasKey(pg => pg.Id);
            modelBuilder.Entity<Pedido>().Property(pg => pg.DescricaoProduto)
                .IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Pedido>().Property(pg => pg.ValorProduto)
                .IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Pedido>().Property(pg => pg.ValorFrete)
               .IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Pedido>()
                .HasData(new List<Pedido>
                {
                new Pedido(1, "Camisa Real Madrid", (float)20.5, (float)2.5, PedidoType.PAGO, FreteType.Terrestre),
                new Pedido(2, "Camisa Barcelona", (float)50.50, (float)25.5, PedidoType.PAGO, FreteType.Terrestre),
                new Pedido(3, "Camisa Corinthians", (float)100.00, (float)25.5, PedidoType.PAGO, FreteType.Terrestre),
                });
        }
    }
}