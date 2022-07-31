using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Application.Interfaces;
using webAPI.Application.Services;
using webAPI.Domain.Interfaces;
using webAPI.Infra.Data.Repositories;

namespace webAPI.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Appliction layer
            services.AddScoped<IproductService, productService>();
            // infra.data layer
            services.AddScoped<IproductRepository, productRepository>();
        }
    }
}
