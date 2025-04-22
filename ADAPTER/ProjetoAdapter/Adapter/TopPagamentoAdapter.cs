using ProjetoAdapter.Pagamento;

namespace ProjetoAdapter.Adapter
{
    public class TopPagamentoAdapter : Gateway
    {
        public TopPagamento topPagamentos;
        public string numeroCartao { get; set; }
        public string cvv { get; set; }
        public double valor { get; set; }
        public int parcelas { get; set; }

        public TopPagamentoAdapter()
        {
            this.topPagamentos = new TopPagamento();
        }

        public void setCVV(string cvv)
        {
            this.cvv = cvv;
        }

        public void setNumeroCartao(string numeroCartao)
        {
            this.numeroCartao = numeroCartao;
        }

        public void setParcelas(int parcelas)
        {
            this.parcelas = parcelas;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public bool validarCartao()
        {
            Console.WriteLine("Cartão validado com sucesso");
            return true;
        }

        public bool realizarPagamento()
        {
            this.topPagamentos.setValorTotal(this.valor);
            this.topPagamentos.setCartao(this.numeroCartao, this.cvv);
            this.topPagamentos.setQuantidadeParcelas(this.parcelas);
            Console.WriteLine("Aprovado");
            return this.topPagamentos.realizarPagamento();
        }
    }
}
