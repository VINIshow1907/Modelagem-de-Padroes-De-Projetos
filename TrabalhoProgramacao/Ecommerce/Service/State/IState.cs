namespace Ecommerce.Service.State
{
    public interface IState
    {
        public void sucessoAoPagar();
        public void cancelarPedido();
        public void despacharPedido();
    }
}
