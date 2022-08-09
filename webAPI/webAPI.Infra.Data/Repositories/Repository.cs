using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using webAPI.Domain.Interfaces;
using webAPI.Infra.Data.Context;

namespace webAPI.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private BuildingsDBContext _ctx;
        public Repository(BuildingsDBContext context)
        {
            _ctx = context;
        }

        public void Add(T entity)
        {
            _ctx.Set<T>().Add(entity);  
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _ctx.Set<T>().AsQueryable().Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            return _ctx.Set<T>();
        }

        public void Remove(T entity)
        {
            _ctx.Set<T>().Remove(entity);
        }
    }
}
