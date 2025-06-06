﻿using Cenario4.Fretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cenario4.Pedidos
{
    public abstract class Pedido
    {
        public double valor { get; set; }
        public string? nomeSetor { get; set; }
        public Frete tipoFrete { get; set; }
        public double calculaFrete ()
        {
            return tipoFrete.calcula(this.valor);
        }
    }
}
