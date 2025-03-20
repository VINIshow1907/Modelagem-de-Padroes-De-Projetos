using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodSolucao.GatewayCobranca;

namespace TemplateMethodSolucao.MetodoPagamento
{
    public abstract class Pagamento
    {
        protected double valor {  get; set; }
        protected Gateway gateway { get; set; }

        //hook method
        public virtual double calcularTaxa()
        {
            return 0;
        }
        //implementado na subclasse
        public abstract double calcularDesconto();
        public Boolean realizarCobranca()
        {
            double valorPago = this.valor + this.calcularTaxa() -this.calcularDesconto();
             this.calcularDesconto();
            return this.gateway.cobrar(valorPago);
        }

    }
}
