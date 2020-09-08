using System;
using Application.Products;
using Infrastructure.JsonPlaceholderApi;
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
            services.AddHttpClient<JsonPlaceholderClient>("JsonPlaceholderClient", config =>
            {
                config.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
                config.Timeout = TimeSpan.FromSeconds(30);
            });

            services.AddTransient<IProductsApi, ProductsApi>();

            services.AddTransient<ProductsService>();
            services.AddDbContext<MLLJK_VictoriaContext>(options => options.UseSqlServer("Server=mlljksqlserver.database.windows.net;Database=MLLJK_Victoria;Trusted_Connection=False;MultipleActiveResultSets=true;User Id=adminadmin;Password=Victoria21;Integrated Security=False;"));
            return services;
        }
    }
}