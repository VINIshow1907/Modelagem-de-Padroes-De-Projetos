namespace ProjetoAdapter.Pagamento
{
    public class TopPagamento
    {
        public void setValorTotal(double valor)
        {
            Console.WriteLine($"Valor total definido: R${valor}");
        }

        public void setCartao(string numeroCartao, string cvv)
        {
            Console.WriteLine($"Cartão configurado: {numeroCartao} - CVV: {cvv}");
        }

        public void setQuantidadeParcelas(int parcelas)
        {
            Console.WriteLine($"Parcelado em: {parcelas}x");
        }

        public bool realizarPagamento()
        {
            Console.WriteLine("Pagamento realizado com sucesso via TopPagamento!");
            return true;
        }
    }
}
