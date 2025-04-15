using ProjetoAdapter.Adapter;

namespace ProjetoAdapter.Cobranca
{
    public class Cobranca : Gateway
    {
        public Gateway gateway { get; set; }
        public double valor { get; set; }
        public int parcelas { get; set; }
        public string numeroCartao { get; set; }
        public string cvv { get; set; }

        public Cobranca() { }

        public void setGateway(Gateway gateway)
        {
            this.gateway = gateway;
            gateway.setValor(valor);
            gateway.setNumeroCartao(numeroCartao);
            gateway.setCVV(cvv);
            gateway.setParcelas(parcelas);
        }

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
            return gateway.validarCartao();
        }

        public bool realizarPagamento()
        {
            return gateway.realizarPagamento();
        }
    }
}
