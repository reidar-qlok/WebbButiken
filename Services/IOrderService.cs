using WebbButiken.Models;

namespace WebbButiken.Services
{
    public interface IOrderService : IOrderNotifier
    {
        void UpdateOrder(Order order);
    }
}
