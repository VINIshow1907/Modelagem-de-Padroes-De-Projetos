using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSolucao.Produto
{
    public abstract class AcrescimoDecorator : Pizza
    {
        protected Pizza pizza;
        public abstract override string getDescricao();
        public abstract override double getPreco();
    }
}
