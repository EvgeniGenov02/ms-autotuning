using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ms_autotuning.Core.Contracts;
using ms_autotuning.Core.Models.AdministratorViewsModels;
using ms_autotuning.Core.Models.ServiceViewsModels;
using ms_autotuning.Core.Services;

namespace ms_autotuning.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        // Get all reviews
        public async Task<IActionResult> AllReviews()
        {
            var models = await _serviceService.AllReviews();
            return View(models);
        }

        //Get all sales
        public async Task<IActionResult> AllSales()
        {
            var models = await _serviceService.AllSales();
            return View(models);
        }

        //Get all services
        public async Task<IActionResult> AllServices()
        {
            var models = await _serviceService.AllServices();

            return View(models);
        }


        //Send a form review formular
        public async Task<IActionResult> AddReviews()
        {
            var models = await _serviceService.AddReview();
            return View(models);
        }

        //add a review in DB and return to all reviews 
        [HttpPost]
        public async Task<IActionResult> AddReviews(ReviewFormModel model)
        {

            if(ModelState.IsValid)
            {
                return BadRequest();
            }

            await _serviceService.AddReview(model);
            return RedirectToAction(nameof(AllReviews));
        }

        //Add Sales
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddSales()
        {
            var model = await _serviceService.AddSales();
            return View(model);
        }

        // Add Sales
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddSales(AddSalesFormModel addSalesFormModel)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _serviceService.AddSales(addSalesFormModel);
            return RedirectToAction("AllSales", "Service");
        }
    }
}
