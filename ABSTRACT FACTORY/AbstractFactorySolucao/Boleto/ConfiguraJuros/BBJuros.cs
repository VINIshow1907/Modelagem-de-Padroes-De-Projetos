﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySolucao.Boleto.ConfiguraJuros;
internal class BBJuros : Juros
{
    public double getJuros()
    {
    return 0.03;
    }
}
