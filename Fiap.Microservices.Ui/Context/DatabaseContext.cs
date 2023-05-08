using Fiap.Microservices.Ui.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Microservices.Ui.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<Contato> Contatos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Contato>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
