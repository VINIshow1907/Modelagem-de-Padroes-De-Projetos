using ProjetoAdapter.Pagamento;

namespace ProjetoAdapter.Adapter
{
    public class PagFacilAdapter : PagFacil, Gateway
    {
        private double valor;
        private int parcelas;
        private string numeroCartao;
        private string cvv;

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public void setParcelas(int parcelas)
        {
            this.parcelas = parcelas;
        }

        public void setNumeroCartao(string numeroCartao)
        {
            this.numeroCartao = numeroCartao;
        }

        public void setCVV(string cvv)
        {
            this.cvv = cvv;
        }

        public bool validarCartao()
        {
            this.configuraCartao(numeroCartao, cvv);
            return this.verificaCartao();
        }

        public bool realizarPagamento()
        {
            this.configuraPagamento(valor, parcelas);
            return this.pagar();
        }
    }
}
