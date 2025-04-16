using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacadeSolucao.vendas
{
    public class PagamentoBoleto : Pagamento
    {
        private Pedido pedido;

        public PagamentoBoleto(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public override bool realizarPagamento()
        {
            return true;
        }
    }
}

