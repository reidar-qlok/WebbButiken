using System.Diagnostics;
using WebbButiken.Models;

namespace WebbButiken.Services
{
    public class EmailObserver : IOrderObserver
    {
        public void Update(Order order)
        {
            Debug.WriteLine("Order no '{0}' status is updated to '{1}'. A email was just sent to the customer",
                order.OrderNumber, order.OrderStatus.ToString());
        }
    }
}
