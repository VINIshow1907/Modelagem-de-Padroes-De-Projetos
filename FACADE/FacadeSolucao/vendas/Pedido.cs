using FacadeSolucao.cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSolucao.vendas
{
    public class Pedido
    {
        public Consumidor consumidor { get; set; }

        public List<Produto> Produtos { get; set; } = new List<Produto>();
        public void AddProduto(Produto produto)
        {
            Produtos.Add(produto);
        }
       

    }

}
