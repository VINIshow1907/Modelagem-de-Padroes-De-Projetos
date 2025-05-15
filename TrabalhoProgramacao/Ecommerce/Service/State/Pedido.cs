namespace Ecommerce.Service.State
{
    public class Pedido
    {
        public IState EstadoAtual { get; set; }

        public Pedido()
        {
            EstadoAtual = new AguardandoPagamentoState(this);
        }

        public void Pagar()
        {
            EstadoAtual.sucessoAoPagar();
        }

        public void Cancelar()
        {
            EstadoAtual.cancelarPedido();
        }

        public void Enviar()
        {
            EstadoAtual.despacharPedido();
        }
    }
}
