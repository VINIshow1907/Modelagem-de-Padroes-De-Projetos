using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSolucao.boletobancario;

public abstract class Boleto
{
    protected double valor;
    protected double juros;
    protected double multa;
    protected double desconto;

    public double calcularJuros()
    {
        return valor * juros;
    }

    public double calcularMulta()
    {
        return valor * multa;
    }

    public double calcularDesconto()
    {
        return valor * desconto;
    }
}

