using webAPI.Domain.Models;

namespace webAPI.Domain.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
    }
}
