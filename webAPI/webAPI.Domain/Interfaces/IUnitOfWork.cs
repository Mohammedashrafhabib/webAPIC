using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Domain.Interfaces;

namespace webAPI.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public void complete();


    }
}
