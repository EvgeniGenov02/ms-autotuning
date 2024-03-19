using Microsoft.AspNetCore.Mvc;
using ms_autotuning.Core.Contracts;
using ms_autotuning.Core.Models.ServiceViewsModels;

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
            var models = new List<SaleViewModel>();

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
            await _serviceService.AddReview(model);
            return RedirectToAction(nameof(AllReviews));
        }


    }
}
