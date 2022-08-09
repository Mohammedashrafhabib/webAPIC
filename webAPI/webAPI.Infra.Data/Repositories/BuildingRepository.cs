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
    public class BuildingRepository : Repository<Building>, IBuildingRepository
    {
        private BuildingsDBContext _ctx;
        public BuildingRepository(BuildingsDBContext context) : base(context)
        {
            _ctx = context;
        }
    }
}
