namespace Cenario3.Pedido
{
    public class PedidoMoveis : Pedido
    {
        public PedidoMoveis()
        {
            this.nomeSetor = "Móveis";
        }
        public override double calcularFreteComum()
        {
            return this.valor * 0.05;
        }
        public override double calcularFreteExpresso()
        {
            throw new Exception("Não é permitido frete expresso");
        }
    }
}
