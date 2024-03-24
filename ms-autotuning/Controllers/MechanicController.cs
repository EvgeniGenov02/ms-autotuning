using Microsoft.AspNetCore.Mvc;
using ms_autotuning.Core.Contracts;
using ms_autotuning.Core.Models.MechanicViewsModels;

namespace ms_autotuning.Controllers
{
    public class MechanicController : Controller
    {
        private readonly IMechanicService _mechanicService;
        public MechanicController(IMechanicService mechanicService)
        {
                _mechanicService = mechanicService;
        }

        //Mechanic Graphs 
        public async Task<IActionResult> MechanicGraph()
        {
            var models = await _mechanicService.MechanicGraph();
            return View(models);
        }

        [HttpPost]
        //Get Order
        public async Task<IActionResult> GetOrder(int id)
        {
            await _mechanicService.GetOrder(id);
            return RedirectToAction(nameof(MechanicGraph));
        }

        [HttpPost]
        //Complete Order
        public async Task<IActionResult> CompleteOrder(int id)
        {
            await _mechanicService.CompleteOrder(id);
            return RedirectToAction(nameof(MechanicGraph));
        }
    }
}
