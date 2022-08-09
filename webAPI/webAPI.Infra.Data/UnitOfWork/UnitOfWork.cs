using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Application.Interfaces;
using webAPI.Domain.Interfaces;
using webAPI.Infra.Data.Context;
using webAPI.Infra.Data.Repositories;

namespace webAPI.Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private  BuildingsDBContext _ctx;

        public UnitOfWork(BuildingsDBContext ctx)
        {
            _ctx = ctx;

    }


        public void complete()
        {
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
            
        }
    }
}
