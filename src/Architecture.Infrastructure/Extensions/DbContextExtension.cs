using Architecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Architecture.Infrastructure.Extensions
{
    public static class DbContextExtension
    {
        public static void AddDbContext(this IServiceCollection services, 
            string connectionString, 
            Assembly migrationAssembly)
        {
            services.AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlServer(connectionString,
                x => x.MigrationsAssembly(migrationAssembly)));
        }
    }
}
