using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodSolucao.GatewayCobranca;

namespace TemplateMethodSolucao.MetodoPagamento
{
    public class PagamentoDinheiro: Pagamento
    {
        public PagamentoDinheiro(double valor, Gateway gateway)
        {
            base.valor = valor;
            base.gateway = gateway;
        }
        public override double calcularDesconto()
        {
            return this.valor * 0.1;
        }
    }
}
