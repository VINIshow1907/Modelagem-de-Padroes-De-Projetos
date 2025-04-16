using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSolucao.cadastros
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, string descricao, double preco)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }
    }
}

