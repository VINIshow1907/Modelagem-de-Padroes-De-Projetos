using Ecommerce.Objects.Dtos.Entities;

namespace Ecommerce.Service.Interfaces
{
    public interface IPedidoService
    {
        Task<IEnumerable<PedidoDTO>> ListAll();
        Task<PedidoDTO> GetById(int id);
        Task<PedidoDTO> GerarPedido(PedidoDTO pedidoDTO);
        Task<PedidoDTO> Atualizar(PedidoDTO pedidoDTO, int id);

        Task<PedidoDTO> SucessoAoPagar(int id);
        Task<PedidoDTO> DespacharPedido(int id);
        Task<PedidoDTO> CancelarPedido(int id);
    }
}