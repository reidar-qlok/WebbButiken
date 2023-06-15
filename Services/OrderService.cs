using WebbButiken.Models;

namespace WebbButiken.Services
{
    public class OrderService : IOrderService
    {
        public List<IOrderObserver> Observers = new List<IOrderObserver>();
        public void Attach(IOrderObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IOrderObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify(Order order)
        {
            foreach (var observer in Observers)
            {
                observer.Update(order);
            }
        }

        public void UpdateOrder(Order order)
        {
            Notify(order);
        }
    }
}
