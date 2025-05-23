namespace Ecommerce.Service.Strategy
{
    public class FreteTerrestre : IFrete
    {
        public double calcula(double Valor)
        {
            return Valor * 0.05;
        }
    }
}