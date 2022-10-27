using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static void AddPersistence(this IServiceCollection services, string connectionString)
        {
            var migrationsAssemblyName = typeof(ApplicationDbContext).Assembly.FullName;
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    connectionString: connectionString,
                    sqlServerOptionsAction: p => p.MigrationsAssembly(migrationsAssemblyName)));
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
        }
    }
}
