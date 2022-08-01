using webAPI.Application.ViewModels;

namespace webAPI.Application.Interfaces
{
    public interface IOrderService
    {
        OrdersViewModel GetOrders();
    }
}
