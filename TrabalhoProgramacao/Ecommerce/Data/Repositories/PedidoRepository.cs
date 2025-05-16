using Ecommerce.Data.Interfaces;
using Ecommerce.Objects.Models;
using System.Threading;

namespace Ecommerce.Data.Repositories
{
    public class PedidoRepository : GenericRepository<Pedido>, IPedidoRepository
    {
        private readonly AppDbContext _context;

        public PedidoRepository(AppDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}