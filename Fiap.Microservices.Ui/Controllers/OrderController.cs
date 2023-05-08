using AutoMapper;
using Fiap.Microservice.Domain;
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
                cfg.AddProfile(new OrderProfile());
            });

            _mapper = config.CreateMapper();
        }

        [HttpGet]
        public async Task<List<OrderEntity>> Index()
        {
            return await _databaseContext.Orders.Include(p => p.Products).Include(p => p.ProductionIds).ToListAsync();
        }

        [HttpPost]
        public async Task<List<OrderEntity>> Create(OrderDto orderDto)
        {
            var order = _mapper.Map<OrderEntity>(orderDto);
            await _databaseContext.Orders.AddAsync(order);
            await _databaseContext.SaveChangesAsync();
            var lista = await _databaseContext.Orders.ToListAsync();
            return lista;
        }
    }
}
