using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace webAPI.Domain.Interfaces
{
    public interface IRepository<Tentity> where Tentity : class
    {
        IEnumerable<Tentity> GetAll();
        void Add(Tentity entity);
        IEnumerable<Tentity> Find(Expression<Func<Tentity, bool>> expression);
       void Remove(Tentity entity);
        public void update(Tentity entity);

    }
}
