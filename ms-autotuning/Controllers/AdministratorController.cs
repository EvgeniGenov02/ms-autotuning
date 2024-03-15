using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using ms_autotuning.Core.Models.AdministratorViewsModels;
using ms_autotuning.Infrastructior.Data.Models;

namespace ms_autotuning.Controllers
{
    public class AdministratorController : Controller
    {
        //Edit Service
        public async Task<IActionResult> EditService(int id)
        {
            return View(new EditServicesFormModel());
        }

        [HttpPost]
        public async Task<IActionResult> EditService(EditServicesFormModel model)
        {
            return RedirectToAction("Service", "AllServices");
        }

        //Delate Review
        [HttpPost]
        public async Task<IActionResult> DelateReview(int id)
        {
            return RedirectToAction("Service", "AllReviews");
        }


        //Delate Service
        [HttpPost]
        public async Task<IActionResult> DelateService(int id)
        {
            return RedirectToAction("Service", "AllServices");
        }


        //Delate Sale
        [HttpPost]
        public async Task<IActionResult> DelateSale(int id)
        {
            return RedirectToAction("Service", "AllSales");
        }

        //Add Order
        public async Task<IActionResult> AddService()
        {
            var model = new AddServiceFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddService(AddServiceFormModel model)
        {
            return RedirectToAction("AllServices", "Service");
        }

        // Add Mechanic
        public async Task<IActionResult> AddMechanic()
        {
            var model = new MechanicFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddMechanic(MechanicFormModel model)
        {
            return RedirectToAction(nameof(AllMechanics));
        }

        //All Mechanics

        public async Task<IActionResult> AllMechanics()
        {
            var models = new List<MechanicsViewModel>();
            return View(models);
        }

        // Delete Mechanic
        [HttpPost]
        public async Task<IActionResult> DeleteMechanic(int id)
        {
            return RedirectToAction(nameof(AllMechanics));
        }

    }
}
