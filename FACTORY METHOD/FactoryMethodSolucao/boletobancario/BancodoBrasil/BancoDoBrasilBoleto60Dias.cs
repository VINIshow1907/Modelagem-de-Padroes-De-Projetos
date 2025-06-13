using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSolucao.boletobancario.BancodoBrasil;
public class BancoDoBrasilBoleto60Dias : Boleto
{
    public BancoDoBrasilBoleto60Dias(double valor)
    {
        this.valor = valor;
        juros = 0.1;
        desconto = 0;
        multa = 0.15;
    }
}
