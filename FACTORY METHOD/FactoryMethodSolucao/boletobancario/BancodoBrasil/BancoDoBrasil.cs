using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSolucao.boletobancario.BancodoBrasil;
    public class BancoDoBrasil : Banco
    {
    protected override Boleto criarBoleto(int vencimento, double valor)
    {
        Boleto boleto;
        switch (vencimento)
        {
            case 10:
                boleto = new BancoDoBrasilBoleto10Dias(valor);
                break;
            case 30:
                boleto = new BancoDoBrasilBoleto30Dias(valor);
                break;
            case 60:
                boleto = new BancoDoBrasilBoleto60Dias(valor);
                break;
            default:
                throw new Exception("Vencimento indisponível");
        }
        return boleto;
    }
}
