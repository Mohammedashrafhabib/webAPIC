using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;
using webAPI.Domain.Interfaces;

namespace webAPI.Application.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _ordersRepository;
        private IUnitOfWork _unitOfWork;
        public OrderService(IOrderRepository repository, IUnitOfWork unitOfWork)
        {
            _ordersRepository = repository;
            _unitOfWork = unitOfWork;
        }
        public OrdersViewModel GetOrders()
        {
            return new OrdersViewModel()
            {
                orders = _ordersRepository.GetAll()
            };
        }
    }
}
