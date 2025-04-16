using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSolucao.cadastros
{
    public class Consumidor
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        public Consumidor(string nome, string email, string cpf)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }
    }
}

