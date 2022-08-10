using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using webAPI.Domain.Interfaces;
using webAPI.Domain.Models;
using webAPI.Infra.Data.Context;

namespace webAPI.Infra.Data.Repositories
{
    public class TransactionRepository : Repository<Transaction>,ITransactionRepository
    {
        private BuildingsDBContext _ctx;
        public TransactionRepository(BuildingsDBContext context) : base(context)
        {
            _ctx = context;
        }

        public IEnumerable<Transaction> GetBuildingTransactions(int id)
        {
            return _ctx.transactions.AsQueryable().Where(x=>(x.BuildingID == id)&&(x.DebtID==null)&&(x.FlatID==null));
        }

        public IEnumerable<Transaction> GetFlatTransactions(int id)
        {
            return _ctx.transactions.AsQueryable().Where(x => x.FlatID == id);
        }

      
    }
}
