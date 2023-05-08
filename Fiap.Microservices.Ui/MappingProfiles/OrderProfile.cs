using AutoMapper;
using Fiap.Microservices.Ui.Models.Dto;
using Fiap.Microservices.Ui.Models;
using Fiap.Microservice.Domain;

namespace Fiap.Microservices.Ui.MappingProfiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderDto, OrderEntity>().ReverseMap();
        }
    }
}
