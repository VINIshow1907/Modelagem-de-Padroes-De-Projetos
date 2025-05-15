using Ecommerce.Objects.Models;

namespace Ecommerce.Service.State
{
    public class AguardandoPagamentoState : IState
    {
        private Pedido pedido;

        public AguardandoPagamentoState(Pedido pedido)
        {
            this.pedido = pedido;
        }
        void IState.cancelarPedido()
        {
            this.pedido.EstadoAtual = new CanceladoState(pedido);
        }
        void IState.despacharPedido()
        {
            throw new Exception("Operação não suportada, " + "pedido ainda não foi pago");
        }
        void IState.sucessoAoPagar()
        {
            this.pedido.EstadoAtual = new PagoState(pedido);
        }
    }
}
