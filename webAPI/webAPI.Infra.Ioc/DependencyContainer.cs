using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Application.Interfaces;
using webAPI.Application.Services;
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
            services.AddScoped<IBuildingService, BuildingService>();
            services.AddScoped<IFlatService, FlatService>();
            services.AddScoped<IDebtService, DebtService>();
            services.AddScoped<ITransactionService, TransactionService>();
            
            
           
           
            // infra.data layer
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IDebtRepository, DebtRepository>();
            services.AddScoped<IFlatRepository, FlatRepository>();
            services.AddScoped<IBuildingService, IBuildingService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
          //  services.AddScoped<IRepository<>, Repository<>>();
        }
    }
}
