using Ecommerce.Objects.Models;
using Ecommerce.Service.State;

namespace Ecommerce.Service.States
{
    public class AguardandoPagamento : IEstadoPedidos
    {
        private Pedido pedido;

        public AguardandoPagamento(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public IEstadoPedidos CancelarPedido()
        {
            return new Cancelado(pedido);
        }

        public IEstadoPedidos DespacharPedido()
        {
            throw new Exception("Operação não suportada, o pedido ainda não foi pago");
        }

        public IEstadoPedidos SucessoAoPagar()
        {
            return new Pago(pedido);
        }
    }
}
