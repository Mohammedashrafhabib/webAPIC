using webAPI.Domain.Interfaces;
using webAPI.Domain.Models;
using webAPI.Infra.Data.Context;

namespace webAPI.Infra.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private CompanyDBContext _ctx;
        public OrderRepository(CompanyDBContext context)
        {
            _ctx = context;
        }
        public IEnumerable<Order> GetOrders()
        {
            return _ctx.orders;
        }
    }
}
