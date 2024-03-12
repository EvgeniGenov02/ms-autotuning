using Microsoft.AspNetCore.Mvc;
using ms_autotuning.Core.Models.MechanicViewsModels;

namespace ms_autotuning.Controllers
{
    public class MechanicController : Controller
    {
        //Mechanic Graphs 
        public async Task<IActionResult> MechanicGraph()
        {
            var model = new List<MechanicGraphViewModel>();
            return View(model);
        }

        [HttpPost]
        //Get Order
        public async Task<IActionResult> GetOrder()
        {
            return RedirectToAction(nameof(MechanicGraph));
        }
    }
}
