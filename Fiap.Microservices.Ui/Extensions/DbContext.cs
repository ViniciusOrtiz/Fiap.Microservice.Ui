using Fiap.Microservices.Ui.Context;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Fiap.Microservices.Ui.Extensions
{
    public static class DbContext
    {
        public static IServiceCollection AddDbContextService(this IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlite("Data Source=Contatos.db")
            );
            return services;
        }
    }
}
