using Ecommerce.Objects.Models;

namespace Ecommerce.Service.State
{
    public class EnviadoState : IEstadoPedidos
    {
        private Pedido pedido;

        public EnviadoState(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public IEstadoPedidos CancelarPedido()
        {
            throw new Exception("Operação não suportada, pedido já foi enviado");
        }

        public IEstadoPedidos DespacharPedido()
        {
            throw new Exception("Operação não suportada, pedido já foi enviado");
        }

        public IEstadoPedidos SucessoAoPagar()
        {
            throw new Exception("Operação não suportada, pedido já foi enviado");
        }
    }
}
