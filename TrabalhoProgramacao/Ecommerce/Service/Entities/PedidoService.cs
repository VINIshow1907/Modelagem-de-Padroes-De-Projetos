using Ecommerce.Data.Interfaces;
using Ecommerce.Objects.Dtos.Entities;
using Ecommerce.Objects.Models;
using Ecommerce.Objects.Enums;
using Ecommerce.Service.Interfaces;
using Ecommerce.Service.State;
using Ecommerce.Service.Strategy;
using Ecommerce.Service.States;

namespace Ecommerce.Service.Entities
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _repository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _repository = pedidoRepository;
        }

        public async Task<IEnumerable<PedidoDTO>> ListAll()
        {
            var pedidos = await _repository.Get();
            List<PedidoDTO> entitiesDTO = [];

            foreach (var entity in pedidos)
            {
                entitiesDTO.Add(ConverterParaDTO(entity));
            }

            return entitiesDTO;
        }

        public async Task<PedidoDTO> GetById(int id)
        {
            var entity = await _repository.GetById(id);

            if (entity == null)
                throw new KeyNotFoundException($"Pedido com id {id} não encontrado.");

            return ConverterParaDTO(entity);
        }

        public async Task<PedidoDTO> GerarPedido(PedidoDTO entitiesDTO)
        {
            if (!Enum.IsDefined(typeof(PedidoType), entitiesDTO.PedidoType))
            {
                throw new ArgumentException("PedidoType inválido.");
            }

            entitiesDTO.PedidoType = (int)PedidoType.Aguardando_Pagamento;

            var entity = ConverterParaModel(entitiesDTO);

            IFrete frete = GerarFretePorTipo(entity.FreteType);
            entity.Valor = (float)frete.calcula(entity.TotalGeral);

            await _repository.GerarPedido(entity);
            return ConverterParaDTO(entity);
        }

        public async Task<PedidoDTO> Atualizar(PedidoDTO entitiesDTO, int id)
        {
            var existingPedido = await _repository.GetById(id);

            if (existingPedido is null)
            {
                throw new KeyNotFoundException($"Pedido com id {id} não encontrado.");
            }

            if (existingPedido.PedidoType == PedidoType.Aguardando_Pagamento)
            {
                IFrete frete = GerarFretePorTipo((FreteType)entitiesDTO.FreteType);
                entitiesDTO.Valor = (float)frete.calcula(entitiesDTO.TotalGeral);
            }
            else
            {
                throw new Exception("Não é permitido atualizar o pedido, após seu pagamento, cancelamento ou despache.");
            }

            var pedido = ConverterParaModel(entitiesDTO);
            await _repository.Update(pedido);

            return entitiesDTO;
        }

        public async Task<PedidoDTO> SucessoAoPagar(int id)
        {
            var pedido = await _repository.GetById(id);

            if (pedido == null)
                throw new KeyNotFoundException($"Pedido com id {id} não encontrado.");

            IEstadoPedidos estadoAtual = ObterStatusClasse(pedido);
            IEstadoPedidos novoEstado = estadoAtual.SucessoAoPagar();
            pedido.PedidoType = ObterEstadoEnum(novoEstado);

            await _repository.Update(pedido);

            return ConverterParaDTO(pedido);
        }

        public async Task<PedidoDTO> DespacharPedido(int id)
        {
            var pedido = await _repository.GetById(id);

            if (pedido == null)
                throw new KeyNotFoundException($"Pedido com id {id} não encontrado.");

            IEstadoPedidos estadoAtual = ObterStatusClasse(pedido);
            IEstadoPedidos novoEstado = estadoAtual.DespacharPedido();
            pedido.PedidoType = ObterEstadoEnum(novoEstado);

            await _repository.Update(pedido);

            return ConverterParaDTO(pedido);
        }

        public async Task<PedidoDTO> CancelarPedido(int id)
        {
            var pedido = await _repository.GetById(id);

            if (pedido == null)
                throw new KeyNotFoundException($"Pedido com id {id} não encontrado.");

            IEstadoPedidos estadoAtual = ObterStatusClasse(pedido);
            IEstadoPedidos novoEstado = estadoAtual.CancelarPedido();
            pedido.PedidoType = ObterEstadoEnum(novoEstado);

            await _repository.Update(pedido);

            return ConverterParaDTO(pedido);
        }

        private IFrete GerarFretePorTipo(FreteType tipoFrete)
        {
            return tipoFrete switch
            {
                FreteType.Aereo => new FreteAereo(),
                FreteType.Terrestre => new FreteTerrestre(),
                _ => throw new ArgumentException("Frete inválido"),
            };
        }

        private IEstadoPedidos ObterStatusClasse(Pedido pedido)
        {
            return pedido.PedidoType switch
            {
                PedidoType.Aguardando_Pagamento => new AguardandoPagamento(pedido),
                PedidoType.Pago => new Pago(pedido),
                PedidoType.Enviado => new EnviadoState(pedido),
                PedidoType.Cancelado => new Cancelado(pedido),
                _ => throw new ArgumentException("Estado inválido"),
            };
        }

        private PedidoType ObterEstadoEnum(IEstadoPedidos state)
        {
            return state switch
            {
                AguardandoPagamento _ => PedidoType.Aguardando_Pagamento,
                Cancelado _ => PedidoType.Cancelado,
                EnviadoState _ => PedidoType.Enviado,
                Pago _ => PedidoType.Pago,
                _ => throw new ArgumentException("Estado inválido"),
            };
        }

        private PedidoDTO ConverterParaDTO(Pedido pedido)
        {
            PedidoDTO pedidoDTO = new()
            {
                Id = pedido.Id,
                Descricao = pedido.Descricao,
                Valor = pedido.Valor,
                TotalGeral = pedido.TotalGeral,
                PedidoType = (int)pedido.PedidoType,
                FreteType = (int)pedido.FreteType,
            };

            return pedidoDTO;
        }

        private Pedido ConverterParaModel(PedidoDTO entitiesDTO)
        {
            Pedido pedido = new()
            {
                Id = entitiesDTO.Id,
                Descricao = entitiesDTO.Descricao, 
                Valor = entitiesDTO.Valor,
                TotalGeral = (float)entitiesDTO.TotalGeral,
                PedidoType = (PedidoType)entitiesDTO.PedidoType,
                FreteType = (FreteType)entitiesDTO.FreteType,
            };

            return pedido;
        }
    }
}
