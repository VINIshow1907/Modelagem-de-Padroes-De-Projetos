using Solucao03.domains.state;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao03.domains
{
    public class Pedido
    {
        public State estadoAtual {  get; set; }

        public Pedido() 
        {
            Console.WriteLine("Pedido Aguardando Pagamento");
            //define estado atual
            this.estadoAtual = new AguardandoPagamentoState(this);
        }
        public void sucessoAoPagar()
        {
            try
            {
                Console.WriteLine("Pedido Pago");
                this.estadoAtual.sucessoAoPagar();
            } catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void cancelarPedido()
        {
            try
            {
                Console.WriteLine("Pedido Cancelado");
                this.estadoAtual.cancelarPedido();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void despacharPedido()
        {
            try
            {
                Console.WriteLine("Pedido enviado");
                this.estadoAtual.despacharPedido();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
