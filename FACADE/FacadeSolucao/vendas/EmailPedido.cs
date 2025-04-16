using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeSolucao.cadastros;

namespace FacadeSolucao.vendas
{
    public class EmailPedido
    {
        private Pedido pedido;

        public EmailPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void enviarEmail(string mensagem)
        {
            Console.WriteLine("Email enviado para: " + pedido.consumidor.Nome);
            Console.WriteLine(mensagem);
        }
    }
}

