using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_SimpleFactory.boletobancario;
public class BancoCaixaBoleto60Dias : Boleto
{
    public BancoCaixaBoleto60Dias(double valor) : base(valor) { }

    public override double calcularJuros() => valor * 0.10;
    public override double calcularMulta() => valor * 0.20;
    public override double calcularDesconto() => 0;
}
