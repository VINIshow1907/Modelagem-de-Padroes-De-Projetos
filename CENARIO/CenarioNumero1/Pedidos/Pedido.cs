using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenarioNumero1.Pedidos
{
    public class Pedido
    {
        public double valor { get; set; }
        public double calcularFreteComum()
        {
            return this.valor*0.05;
        }
        public double calcularFreteExpresso() 
        {
            return this.valor * 0.1;
        }
    }
}
