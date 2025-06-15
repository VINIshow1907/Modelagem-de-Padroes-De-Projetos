using AbstractFactorySolucao.Boleto.ConfiguraDesconto;
using AbstractFactorySolucao.Boleto.ConfiguraJuros;
using AbstractFactorySolucao.Boleto.ConfiguraMulta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySolucao.Boleto.Familia;
public interface CalculosFactory
{
    public Juros criarJuros();
    public Desconto criarDesconto();
    public Multa criarMulta();
}
