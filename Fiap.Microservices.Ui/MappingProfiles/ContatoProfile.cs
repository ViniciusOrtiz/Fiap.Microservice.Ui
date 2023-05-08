using AutoMapper;
using Fiap.Microservices.Ui.Models;
using Fiap.Microservices.Ui.Models.Dto;

namespace Fiap.Microservices.Ui.MappingProfiles
{
    public class ContatoProfile : Profile
    {
        public ContatoProfile()
        {
            CreateMap<ContatoDto, Contato>().ReverseMap();
        }
    }
}
