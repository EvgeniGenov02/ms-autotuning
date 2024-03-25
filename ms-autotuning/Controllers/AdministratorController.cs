using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ms_autotuning.Core.Contracts;
using ms_autotuning.Core.Models.AdministratorViewsModels;

namespace ms_autotuning.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdministratorController : Controller
    {
        private readonly IAdministratorService _administratorService;
        public AdministratorController(IAdministratorService administratorService)
        {
            _administratorService = administratorService;
        }

        //Edit Service
        [HttpGet]
        public async Task<IActionResult> EditService(int id)
        {
            var model =await _administratorService.GetService(id);         
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> EditService(EditServicesFormModel model)
        {
            await _administratorService.EditService(model);
            return RedirectToAction("AllServices", "Service");
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
            await _administratorService.DelateSale(id);
            return RedirectToAction("AllSales", "Service");
        }

        //Add Order
        public IActionResult AddService()
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
        public IActionResult AddMechanic()
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
