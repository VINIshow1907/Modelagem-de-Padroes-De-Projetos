using AutoMapper;
using Ecommerce.Objects.Dtos.Entities;
using Ecommerce.Objects.Models;
using Ecommerce.Service;
using System.Runtime;

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
