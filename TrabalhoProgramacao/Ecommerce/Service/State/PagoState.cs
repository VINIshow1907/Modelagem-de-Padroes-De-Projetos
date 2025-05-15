using Ecommerce.Objects.Models;

namespace Ecommerce.Service.State
{
    public class PagoState : IState
    {
        private Pedido pedido;
        public PagoState(Pedido pedido)
        {
            this.pedido = pedido;
        }
        void IState.cancelarPedido()
        {
            this.pedido.EstadoAtual = new CanceladoState(pedido);
        }
        void IState.despacharPedido()
        {
            this.pedido.EstadoAtual = new EnviadoState(pedido);
        }
        void IState.sucessoAoPagar()
        {
            throw new Exception("Operação não suportada, pedido já foi pago");
        }
    }
}
