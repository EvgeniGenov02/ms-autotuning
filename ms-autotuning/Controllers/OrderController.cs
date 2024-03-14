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

        //Get Order
        [HttpPost]
        public async Task<IActionResult> GetOrder(OrdersViewModel order)
        {
            return RedirectToAction(nameof(AllOrders));
        }

        //Delete Order
        [HttpPost]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            return RedirectToAction(nameof(AllOrders));
        }

        //Delete Order
        [HttpPost]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            return RedirectToAction(nameof(AllReservations));
        }
    }
}
