namespace Cenario3.Pedido
{
    public abstract class Pedido
    {
        public double valor {  get; set; }
        public string nomeSetor { get; set; }

        public abstract double calcularFreteComum();
        public abstract double calcularFreteExpresso();
    }
}
