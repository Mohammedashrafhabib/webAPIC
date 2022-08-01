using webAPI.Domain.Models;

namespace webAPI.Application.ViewModels
{
    public class OrdersViewModel
    {
        public IEnumerable<Order> orders { get; set; }
    }
}
