using Ecommerce.Objects.Models;
using Ecommerce.Service.Entities;

namespace Ecommerce.Service.State
{
    public interface IEstadoPedidos
    {
        IEstadoPedidos SucessoAoPagar();
        IEstadoPedidos DespacharPedido();
        IEstadoPedidos CancelarPedido();

    }
}
