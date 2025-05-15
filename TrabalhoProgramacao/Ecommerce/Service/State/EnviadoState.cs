using Ecommerce.Objects.Models;

namespace Ecommerce.Service.State
{
    public class EnviadoState : IState
    {
        private Pedido pedido;
        public EnviadoState(Pedido pedido)
        {
            this.pedido = pedido;
        }
        void IState.cancelarPedido()
        {
            throw new Exception("Operação não suportada, pedido já foi enviado");
        }
        void IState.despacharPedido()
        {
            throw new Exception("Operação não suportada, pedido já foi enviado");
        }
        void IState.sucessoAoPagar()
        {
            throw new Exception("Operação não suportada, pedido já foi enviado");
        }
    }
}
