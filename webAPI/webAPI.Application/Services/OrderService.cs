using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;
using webAPI.Domain.Interfaces;

namespace webAPI.Application.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _ordersRepository;
        public OrderService(IOrderRepository repository)
        {
            _ordersRepository = repository;
        }
        public OrdersViewModel GetOrders()
        {
            return new OrdersViewModel()
            {
                orders = _ordersRepository.GetOrders()
            };
        }
    }
}
