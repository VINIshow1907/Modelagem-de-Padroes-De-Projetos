namespace Cenario2.Pedidos
{
    public abstract class Pedido
    {
        public double valor {  get; set; }
        public string? nomeSetor { get; set; }
        public double calcularFreteComum()
        {
            return this.valor * 0.05;
        }
        public double calcularFreteExpresso()
        {
            return this.valor * 0.1;
        }
    }
}
