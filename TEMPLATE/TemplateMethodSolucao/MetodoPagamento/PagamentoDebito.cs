using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodSolucao.GatewayCobranca;

namespace TemplateMethodSolucao.MetodoPagamento
{
   public class PagamentoDebito : Pagamento
    {
        public PagamentoDebito(double valor, Gateway gateway)
        {
            base.valor = valor;
            base.gateway = gateway;
        }
        public override double calcularTaxa()
        {
            return this.valor * 0.05;
        }
        public override double calcularDesconto()
        {
            return this.valor * 0.096; 
            
        }

    }
}

