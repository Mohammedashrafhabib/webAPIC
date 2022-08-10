﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Domain.Interfaces;
using webAPI.Domain.Models;
using webAPI.Infra.Data.Context;

namespace webAPI.Infra.Data.Repositories
{
    public class DebtRepository : Repository<Debt>, IDebtRepository
    {
        private BuildingsDBContext _ctx;
        public DebtRepository(BuildingsDBContext context) : base(context)
        {
            _ctx = context;
        }

        public IEnumerable<Debt> GetAllFlatDebt(int id)
        {
           
            return _ctx.debts.AsQueryable().Where(x=>x.FlatID == id);
        }

        public IEnumerable<Debt> GetDueDebts(int id)
        {
            return _ctx.debts.AsQueryable().Where(x => (x.FlatID == id)&&x.IsDue==true);
        }
    }
}