using AutoMapper;
using Fiap.Microservices.Ui.Context;
using Fiap.Microservices.Ui.MappingProfiles;
using Fiap.Microservices.Ui.Models;
using Fiap.Microservices.Ui.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Microservices.Ui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;
        private IMapper _mapper;

        public OrderController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile(new ContatoProfile());
            });

            _mapper = config.CreateMapper();
        }

        [HttpGet]
        public async Task<List<Contato>> Index()
        {
            return await _databaseContext.Contatos.ToListAsync();
        }

        [HttpPost]
        public async Task<List<Contato>> Create(ContatoDto contatoDto)
        {
            var contato = _mapper.Map<Contato>(contatoDto);
            await _databaseContext.Contatos.AddAsync(contato);
            await _databaseContext.SaveChangesAsync();
            var lista = await _databaseContext.Contatos.ToListAsync();
            return lista;
        }
    }
}
