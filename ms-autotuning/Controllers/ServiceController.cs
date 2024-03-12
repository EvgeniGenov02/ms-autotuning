﻿using Microsoft.AspNetCore.Mvc;
using ms_autotuning.Core.Models.ServiceViewsModels;

namespace ms_autotuning.Controllers
{
    public class ServiceController : Controller
    {
        // Get all reviews
        public async Task<IActionResult> AllReviews()
        {
            var models = new List<ReviewViewModel>();
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
            var models = new List<ServiceViewModel>();

            return View(models);
        }


        //Send a form review formular
        public async Task<IActionResult> AddReviews()
        {
            var models = new ReviewFormModel();
            return View(models);
        }

        //add a review in DB and return to all reviews 
        [HttpPost]
        public async Task<IActionResult> AddReview(ReviewViewModel model)
        {

            return RedirectToAction(nameof(AllReviews));
        }


    }
}
