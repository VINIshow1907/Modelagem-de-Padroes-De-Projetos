using Ecommerce.Objects.Models;
using Ecommerce.Service.State;

namespace Ecommerce.Service.States
{
    public class Pago : IEstadoPedidos
    {
        private Pedido pedido;

        public Pago(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public IEstadoPedidos CancelarPedido()
        {
            return new Cancelado(pedido);
        }

        public IEstadoPedidos DespacharPedido()
        {
            return new EnviadoState(pedido);
        }

        public IEstadoPedidos SucessoAoPagar()
        {
            throw new Exception("Operação não suportada, o pedido já foi pago");
        }
    }
}
