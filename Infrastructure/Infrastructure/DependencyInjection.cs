
using Application.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
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
            //services.AddDbContext<ApplicationDbContext>(options =>
            //options.UseSqlServer(
            //    configuration.GetConnectionString("DefaultConnection"),
            //    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
        }
    }
}
