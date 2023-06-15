using WebbButiken.Models;

namespace WebbButiken.Services
{
    public interface IOrderObserver
    {
        void Update(Order order);
    }
}
