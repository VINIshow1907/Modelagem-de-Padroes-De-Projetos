using Solucao1.domains.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao1.domains
{
    public class Pedido
    {
        private StatusPedido statusPedido { get; set; }
        public Pedido() 
        {
            Console.WriteLine("Pedido Aguardando Pagamento");
            this.statusPedido = StatusPedido.AGUARDANDO_PAGAMENTO;
        }
        public void sucessoAoApagar()
        {
            if (this.statusPedido == StatusPedido.AGUARDANDO_PAGAMENTO)
            {
                //muda o status
                Console.WriteLine("Pedido Pago");
                this.statusPedido = StatusPedido.PAGO;
            }
            else
            {
                throw new Exception("O pedido não está aguardando pagamento");
            }
        }
        public void cancelarPedido()
        {
            if (this.statusPedido == StatusPedido.PAGO ||
                this.statusPedido == StatusPedido.AGUARDANDO_PAGAMENTO)
            {
                //muda o status
                Console.WriteLine("Pedido Cancelado");
                this.statusPedido = StatusPedido.CANCELADO;
            }
            else
            {
                throw new Exception("O pedido se encontra " + this.statusPedido.ToString());
            }      
        }
        public void despacharPedido()
        {
            if (this.statusPedido == StatusPedido.PAGO) 
            {
                //muda o status
                Console.WriteLine("Pedido Enviado");
                this.statusPedido = StatusPedido.ENVIADO;
            } else
            {
                throw new Exception("O pedido se encontra cancelado");
            }
        }
    }
}
