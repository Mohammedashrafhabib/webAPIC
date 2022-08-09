using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Domain.Interfaces;
using webAPI.Domain.Models;
using webAPI.Infra.Data.Context;

namespace webAPI.Infra.Data.Repositories
{
    public class FlatRepository : Repository<Flat>, IFlatRepository
    {
        private BuildingsDBContext _ctx;
        public FlatRepository(BuildingsDBContext context) : base(context)
        {
            _ctx = context;
        }

        public IEnumerable<Debt> GetAllFlatDebt(int id)
        {
            throw new NotImplementedException();
        }

        public Building GetBuilding(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Debt> GetDueDebts(int id)
        {
            throw new NotImplementedException();
        }
    }
}
