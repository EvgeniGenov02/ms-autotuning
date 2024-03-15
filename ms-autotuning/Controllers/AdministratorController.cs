using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using ms_autotuning.Core.Contracts;
using ms_autotuning.Core.Models.AdministratorViewsModels;
using ms_autotuning.Core.Services;
using ms_autotuning.Infrastructior.Data.Models;

namespace ms_autotuning.Controllers
{
    public class AdministratorController : Controller
    {
        private readonly IAdministratorService _administratorService;
        public AdministratorController(IAdministratorService administratorService)
        {
            _administratorService = administratorService;
        }

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
            await _administratorService.DelateService(id);
            return RedirectToAction("AllServices", "Service");
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
            await _administratorService.AddService(model);
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
            await _administratorService.AddMechanic(model);

            return RedirectToAction(nameof(AllMechanics));
        }

        //All Mechanics

        public async Task<IActionResult> AllMechanics()
        {
            var models =await _administratorService.AllMechanics();
            return View(models);
        }

        // Delete Mechanic
        [HttpPost]
        public async Task<IActionResult> DeleteMechanic(int id)
        {
            await _administratorService.DeleteMechanic(id);
            return RedirectToAction(nameof(AllMechanics));
        }

    }
}
