using webAPI.Domain.Interfaces;
using webAPI.Domain.Models;
using webAPI.Infra.Data.Context;

namespace webAPI.Infra.Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private CompanyDBContext _ctx;
        public OrderRepository(CompanyDBContext context):base(context)
        {
            _ctx = context;
        }
       
    }
}
