﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSolucao.boletobancario.Caixa;
public class BancoCaixaBoleto60Dias : Boleto
{
    public BancoCaixaBoleto60Dias(double valor)
    {
        this.valor = valor;
        juros = 0.1;
        desconto = 0;
        multa = 0.20;
    }
}
