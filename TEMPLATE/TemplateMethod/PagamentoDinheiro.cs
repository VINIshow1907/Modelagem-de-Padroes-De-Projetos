﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.GateawyCobranca;

namespace TemplateMethod.Pagamento
{
    public class PagamentoDinheiro
    {
        private double valor {  get; set; }
        private Gateway gateway { get; set; }
        public PagamentoDinheiro(double valor, Gateway gateway)
        {
            this.valor = valor;
            this.gateway = gateway;
        }
        public double calcularTaxa()
        {
            return 0;
        }
        public double calcularDesconto()
        {
            return this.valor * 0.1;
        }
        public Boolean realizarCobranca()
        {
            double valorPago =
                this.valor + this.calcularTaxa()
                - this.calcularDesconto();
            return this.gateway.cobrar(valorPago);
        }
    }
}
