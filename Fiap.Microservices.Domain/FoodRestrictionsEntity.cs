using Microsoft.EntityFrameworkCore;

namespace Fiap.Microservice.Domain
{
    [Keyless]
    public class FoodRestrictionsEntity
    {
        public List<RestrictionEntity> Restrictions { get; set; } = new List<RestrictionEntity>();
        public string Others { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int RequesterId { get; set; }

    }
}