using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Application.Interfaces;
//using webAPI.Application.Services;
using webAPI.Domain.Interfaces;
using webAPI.Infra.Data.Repositories;
using webAPI.Infra.Data.UnitOfWork;

namespace webAPI.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Appliction layer
            /*services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ICategoryService, CategoryService>();
            
            
            services.AddScoped<IProductOrderCategoryService, ProductOrderCategoryService>();
           
            // infra.data layer
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
          //  services.AddScoped<IRepository<>, Repository<>>();*/
        }
    }
}
