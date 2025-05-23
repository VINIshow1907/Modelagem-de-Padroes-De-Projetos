namespace Ecommerce.Objects.Dtos.Entities
{
    public class PedidoDTO
    {
    public int Id { get; set; }
    public string Descricao { get; set;}
    public float Valor {  get; set;}
    public double TotalGeral { get; set; }
    public int PedidoType { get; set; }
    public int FreteType { get; set; }

    }
}
