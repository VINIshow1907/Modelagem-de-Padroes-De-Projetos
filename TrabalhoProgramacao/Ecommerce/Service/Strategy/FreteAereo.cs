namespace Ecommerce.Service.Strategy
{
    public class FreteAereo : IFrete
    {
        public double calcula(double Valor)
        {
            return Valor * 0.1;
        }
    }
}