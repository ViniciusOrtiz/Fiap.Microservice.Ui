using System.ComponentModel.DataAnnotations;

namespace Fiap.Microservice.Domain
{
    public class ProductionEntity
    {
        [Key]
        public int ProductionId { get; set; }
    }
}
