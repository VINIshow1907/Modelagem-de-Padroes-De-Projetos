using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Objects.Models;

[Table("pedido")]
public class Pedido
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("descricao")]
    public string Descricao { get; set; }

    [Column("valor")]
    public float Valor {  get; set; }
}
