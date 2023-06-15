using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebbButiken.Models;
using WebbButiken.Services;

namespace WebbButiken.Controllers
{
    public class HomeController : Controller
    {
       private readonly IOrderService _orderService;

        public HomeController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        //GET
        public IActionResult Index()
        {
            var order = new Order()
            {
                OrderNumber="1234398765",
                OrderDate=DateTime.Now,
                TotalAmount=237.6m,
                OrderStatus=OrderStatuses.PendingPayment
            };
            return View(order);
        }
        [HttpPost]
        public IActionResult Index(Order order) 
        {
            Debug.WriteLine("Attching Observers");
            var emailObserver = new EmailObserver();
            var smsObserver=new SMSObserver();
            _orderService.Attach(emailObserver);
            _orderService.Attach(smsObserver);
            Debug.WriteLine("Detaching SMS");
            _orderService.Detach(emailObserver);

            Debug.WriteLine("Updating orderstatus");
            _orderService.UpdateOrder(order);
            return View(order);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}