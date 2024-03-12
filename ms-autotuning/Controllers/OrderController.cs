using Microsoft.AspNetCore.Mvc;
using ms_autotuning.Core.Models.OrderViewsModels;

namespace ms_autotuning.Controllers
{
    public class OrderController : Controller
    {
        //All Reservations
        public async Task<IActionResult> AllReservations()
        {
            var model = new List<ReservationViewModel>();
            return View(model);
        }

        //All Orders
        public async Task<IActionResult> AllOrders()
        {
            var model = new List<OrdersViewModel>();
            return View(model);
        }
    }
}
