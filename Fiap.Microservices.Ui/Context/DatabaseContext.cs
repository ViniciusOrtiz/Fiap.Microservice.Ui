using Fiap.Microservice.Domain;
using Fiap.Microservices.Ui.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Microservices.Ui.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<OrderEntity> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
