using System.ComponentModel.DataAnnotations;

namespace Fiap.Microservice.Domain
{
    public class ProductEntity
    {
        [Key]
        public int ProductId { get; set; }
    }
}