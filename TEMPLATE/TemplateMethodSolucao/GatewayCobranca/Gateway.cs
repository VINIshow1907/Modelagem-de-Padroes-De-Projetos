using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodSolucao.GatewayCobranca
{
    public class Gateway
    {
        public Boolean cobrar(double valor)
        {
            bool[] respostas = { true, false };
            //imprime o valor cobrado
            Console.WriteLine("Valor Cobrado: R$ " + valor);
            //retorna true ou false para confirmação da cobrança por sorteio aleatorio
            return respostas[new Random().Next(0,1)];
        }
    }
}
