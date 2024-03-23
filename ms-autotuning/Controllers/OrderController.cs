using Microsoft.AspNetCore.Mvc;
using ms_autotuning.Core.Contracts;
using ms_autotuning.Core.Models.OrderViewsModels;
using ms_autotuning.Core.Models.ServiceViewsModels;
using ms_autotuning.Core.Services;

namespace ms_autotuning.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _оrderService;
        public OrderController(IOrderService оrderService)
        {
            _оrderService = оrderService;
        }

        //Create Reservation
        //Send a form reservation formular
        public async Task<IActionResult> AddReservation()
        {
            var models = await _оrderService.AddReservation();
            return View(models);
        }

        //add a reservation in DB and return to all reservations 
        [HttpPost]
        public async Task<IActionResult> AddReservation(ReservationFormModel model)
        {
            await _оrderService.AddReservation(model);
            return RedirectToAction(nameof(AllReservations));
        }


        //All Reservations
        [HttpGet]
        public async Task<IActionResult> AllReservations()
        {
            var model = await _оrderService.AllReservations();
            return View(model);
        }

        //All Orders
        [HttpGet]
        public async Task<IActionResult> AllOrders()
        {
            var model = new List<OrdersViewModel>();
            return View(model);
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
            await _оrderService.DeleteReservation(id);
            return RedirectToAction(nameof(AllReservations));
        }
    }
}
