using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Fiap.Microservice.Domain
{
    public class OrderEntity
    {
        [Key]
        public int OrderId { get; set; }
        public string StoreName { get; set; } = string.Empty;
        public string Total { get; set; } = string.Empty;
        public List<ProductEntity> Products { get; set; } = new List<ProductEntity>();
        public List<ProductionEntity> ProductionIds { get; set; } = new List<ProductionEntity>();
    }
}