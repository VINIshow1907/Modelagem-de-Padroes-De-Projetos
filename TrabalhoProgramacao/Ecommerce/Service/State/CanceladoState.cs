using Ecommerce.Objects.Models;

namespace Ecommerce.Service.State
{
    public class CanceladoState : IState
    {
        private Pedido pedido;
        public CanceladoState(Pedido pedido)
        {
            this.pedido = pedido;
        }
        void IState.cancelarPedido()
        {
            throw new Exception("Operação não suportada, pedido foi cancelado");
        }
        void IState.despacharPedido()
        {
            throw new Exception("Operação não suportada, pedido foi cancelado");
        }
        void IState.sucessoAoPagar()
        {
            throw new Exception("Operação não suportada, pedido foi cancelado");
        }
    }
}
