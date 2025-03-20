namespace Cenario3.Pedido
{
    internal class PedidoEletronico : Pedido
    {
        public PedidoEletronico()
        {
            this.nomeSetor = "Eletronicos";
        }
        public override double calcularFreteComum()
        {
            return this.valor * 0.05;
        }
        public override double calcularFreteExpresso()
        {
            return this.valor * 0.1;
        }
    }
}
