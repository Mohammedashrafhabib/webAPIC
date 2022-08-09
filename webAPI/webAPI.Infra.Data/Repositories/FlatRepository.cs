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

      

        public Building GetBuilding(int id)
        {
            //var buildingID=_ctx.flats.AsQueryable().Where(x=>x.FlatID==id).First().Building;
            return _ctx.flats.AsQueryable().Where(x => x.FlatID == id).First().Building;
        }

       
    }
}
