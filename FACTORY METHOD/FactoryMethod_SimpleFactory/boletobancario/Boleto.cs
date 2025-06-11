using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_SimpleFactory.boletobancario;

public abstract class Boleto
{
    protected double valor;

    public Boleto(double valor)
    {
        this.valor = valor;
    }

    public abstract double calcularJuros();
    public abstract double calcularMulta();
    public abstract double calcularDesconto();
}
