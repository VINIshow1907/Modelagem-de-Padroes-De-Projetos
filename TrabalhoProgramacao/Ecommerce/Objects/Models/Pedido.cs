using Ecommerce.Objects.Enums;
using Ecommerce.Service.State;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Xml.Linq;

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

    [Column("totalgeral")]
    public float TotalGeral { get; set; }

    [Column("tipopedido")]
    public PedidoType PedidoType { get; set; }

    [Column("tipofrete")]
    public FreteType FreteType { get; set; }

    public Pedido() { }
    public Pedido(int id, string descricao, float valor, float totalgeral, PedidoType statusPedido, FreteType tipoFrete)
    {
        Id = id;
        Descricao = descricao;
        Valor = valor;
        TotalGeral = totalgeral;
        PedidoType = PedidoType.Aguardando_Pagamento;
        FreteType = tipoFrete;
    }
}

