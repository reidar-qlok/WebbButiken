using WebbButiken.Models;

namespace WebbButiken.Services
{
    public interface IOrderNotifier
    {
        //Lägg till
        void Attach(IOrderObserver observer);
        //Ta bort
        void Detach(IOrderObserver observer);
        // Meddella alla observers om en event
        void Notify(Order order);
    }
}
