using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.GateawyCobranca
{
    public class Gateway
    {
        public Boolean cobrar(double valor)
        {
            bool[] respostas = { true, false };
            //imprimi o valor cobrado
            Console.WriteLine("Valor Cobrado: R$" + valor);
            //retorna true ou false para confirmação da 
            //cobrança por sorteio aleatorio.
            return respostas[new Random().Next(0, 1)];
        }
    }
}
