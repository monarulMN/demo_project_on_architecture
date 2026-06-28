using Architecture.Application.Contracts;
using Architecture.Infrastructure.Data;
using Architecture.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Infrastructure.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDependency(this IServiceCollection services)
        {
            services.AddScoped<IApplicationUnitOfWork, ApplicationUnitOfWork>();
            services.AddScoped<IProductRepository, ProductRepository>();

            //services.AddScoped<>();// one instance per http life cycle
            //services.AddSingleton<>(); // one instance application life cycle
            //services.AddTransient<>(); // always new instance

            //services.AddKeyedScoped<>("parameter1");
            //services.AddKeyedScoped<>("parameter2");

            //services.AddScoped<,>(s => new className("parameter"));

            return services;
        }
    }
}
