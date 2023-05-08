using System.ComponentModel.DataAnnotations;

namespace Fiap.Microservice.Domain
{
    public class RestrictionEntity
    {
        [Key]
        public string Name { get; set; } = string.Empty;
    }
}
