using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_SimpleFactory.boletobancario;
public class BancoCaixaBoleto30Dias : Boleto
{
    public BancoCaixaBoleto30Dias(double valor) : base(valor) { }

    public override double calcularJuros() => valor * 0.05;
    public override double calcularMulta() => valor * 0.10;
    public override double calcularDesconto() => valor * 0.05;
}
