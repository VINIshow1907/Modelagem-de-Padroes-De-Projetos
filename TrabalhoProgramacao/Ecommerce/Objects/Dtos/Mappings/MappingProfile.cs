using AutoMapper;
using Ecommerce.Objects.Dtos.Entities;
using Ecommerce.Objects.Models;

namespace Ecommerce.Objects.Dtos.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<PedidoDTO, Pedido>().ReverseMap();
        }
    }
}
