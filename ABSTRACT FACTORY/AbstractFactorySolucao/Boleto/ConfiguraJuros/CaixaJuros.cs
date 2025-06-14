using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySolucao.Boleto.ConfiguraJuros;

internal class CaixaJuros : Juros
{
    public double getJuros()
    {
        return 0.02;
    }
}
