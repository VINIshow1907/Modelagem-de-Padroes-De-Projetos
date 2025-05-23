using Ecommerce.Objects.Models;
using Ecommerce.Service.State;

namespace Ecommerce.Service.States
{
    public class Cancelado : IEstadoPedidos
    {
        private Pedido pedido;

        public Cancelado(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public IEstadoPedidos CancelarPedido()
        {
            throw new Exception("Operação não suportada, o pedido foi cancelado");
        }

        public IEstadoPedidos DespacharPedido()
        {
            throw new Exception("Operação não suportada, o pedido foi cancelado");
        }

        public IEstadoPedidos SucessoAoPagar()
        {
            throw new Exception("Operação não suportada, o pedido foi cancelado");
        }
    }
}
