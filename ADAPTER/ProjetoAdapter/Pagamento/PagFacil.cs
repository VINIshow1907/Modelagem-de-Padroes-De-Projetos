namespace ProjetoAdapter.Pagamento
{
    public class PagFacil
    {
        private double valor;
        private int parcelas;
        private string numeroCartao;
        private string cvv;

        public void configuraPagamento(double valor, int parcelas)
        {
            this.valor = valor;
            this.parcelas = parcelas;
        }

        public void configuraCartao(string numeroCartao, string cvv)
        {
            this.numeroCartao = numeroCartao;
            this.cvv = cvv;
        }

        public bool verificaCartao()
        {
            return !string.IsNullOrEmpty(numeroCartao) && !string.IsNullOrEmpty(cvv);
        }

        public bool pagar()
        {
            return true;
        }
    }
}
