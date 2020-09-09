using System;
using Application.Products;
using Infrastructure.Apis;
using Infrastructure.Persistence;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IProductsApi, ProductsApi>();
            services.AddTransient<ProductsService>();
            services.AddDbContext<MLLJK_VictoriaContext>(options => options.UseSqlServer("Server=mlljksqlserver.database.windows.net;Database=MLLJK_Victoria;Trusted_Connection=False;MultipleActiveResultSets=true;User Id=adminadmin;Password=Victoria21;Integrated Security=False;"));
            return services;
        }
    }
}