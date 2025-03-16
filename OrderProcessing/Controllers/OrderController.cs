using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Models;

namespace OrderProcessing.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessOrder(OrderModel order)
        {
            if (order.Amount >= 100 && order.CustomerType == "Loyal")
            {
                order.Discount = order.Amount * 0.10; // 10% discount
            }
            else
            {
                order.Discount = 0;
            }

            order.FinalTotal = order.Amount - order.Discount;
            return View("Result", order);
        }

    }
}
