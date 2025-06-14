﻿using AbstractFactorySolucao.Boleto.ConfiguraDesconto;
using AbstractFactorySolucao.Boleto.ConfiguraJuros;
using AbstractFactorySolucao.Boleto.ConfiguraMulta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySolucao.Boleto.Familia;
public class CaixaCalculosFactory : CalculosFactory
{
    public Desconto criarDesconto()
    {
        return new CaixaDesconto();
    }
    public Juros criarJuros()
    {
        return new CaixaJuros();
    }
    public Multa criarMulta() 
    {
        return new CaixaMulta();
    }


}
