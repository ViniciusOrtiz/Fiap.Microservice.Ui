using Fiap.Microservice.Domain;

namespace Fiap.Microservices.Ui.Models.Dto
{
    public class OrderDto
    {
        public string StoreName { get; set; } = string.Empty;
        public string Total { get; set; } = string.Empty;
        public List<ProductEntity> Products { get; set; } = new List<ProductEntity>();
        public List<ProductionEntity> ProductionIds { get; set; } = new List<ProductionEntity>();
    }
}
