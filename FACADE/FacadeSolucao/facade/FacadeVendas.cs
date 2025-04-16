using FacadeSolucao.cadastros;
using FacadeSolucao.vendas;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSolucao.facade
{
    public class FacadeVendas
    {
        private Pedido pedido;
        private Pagamento pagamento;
        private EmailPedido email;

        public FacadeVendas(Consumidor consumidor)
        {
            this.pedido = new Pedido();
            this.pedido.consumidor = consumidor;

            this.email = new EmailPedido(pedido);
        }

        public void addProduto(Produto produto)
        {
            this.pedido.AddProduto(produto); 
        }

        public void PedidoCredito()
        {
            this.pagamento = new PagamentoCredito(this.pedido);
            if (this.pagamento.realizarPagamento() )
            {
                this.email.enviarEmail("Pagamento realizado " + "do pedido");
            }
        }
        public void pedidoBoleto()
        {
            this.pagamento = new PagamentoBoleto(this.pedido);
            if (this.pagamento.realizarPagamento())
            {
                this.email.enviarEmail("Pagamento realizado " + "com sucesso (boleto)");
            }
            else
            {
                this.email.enviarEmail("Falha no pagamento " + "do pedido");
            }
        }
    }
}
