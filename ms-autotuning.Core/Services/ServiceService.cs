using Microsoft.AspNetCore.Identity;
using ms_autotuning.Core.Contracts;
using ms_autotuning.Core.Models.ServiceViewsModels;
using ms_autotuning.Infrastructior.Data.Models;
using ms_autotuning.Infrastructior.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ms_autotuning.Core.Models.AdministratorViewsModels;
using ms_autotuning.Core.Models.OrderViewsModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Documents;

namespace ms_autotuning.Core.Services
{
    public class ServiceService : IServiceService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ServiceService(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<ReviewFormModel> AddReview()
        {
            var reviewFormModel = new ReviewFormModel();

           
            List<Service> services = await _context.Services
            .AsNoTracking()
            .ToListAsync();

            reviewFormModel.Services = services; 

            return reviewFormModel;
        }
        private string GetUserIdFromHttpContext()
        {
            var httpContext = _httpContextAccessor.HttpContext;

            if (httpContext == null)
            {
                return null; 
            }

            var user = _userManager.GetUserAsync(httpContext.User).Result;
            return user?.Id;
        }
        public async Task AddReview(ReviewFormModel model)
        {
            var userId = GetUserIdFromHttpContext();
            var review = new Review()
            {
                ServiceId = model.ServiceId,
                UserId = userId,
                Rating = model.Rating,
                Feedback = model.Feedback,
                
            };

           await _context.Reviews.AddAsync(review);
           await _context.SaveChangesAsync();

        }

        public async Task<List<ReviewViewModel>> AllReviews()
        {
            var reviews = await _context.Reviews
                .AsNoTracking()
                .Select(r => new ReviewViewModel()
                {
                    Id = r.Id,
                    ServiceId = r.ServiceId,
                    Services = r.Service,
                    UserId = r.UserId,
                    Rating = r.Rating,
                    Feedback = r.Feedback,
                })
                .ToListAsync();

            return reviews;
        }

        public async Task<AddSalesFormModel> AddSales()
        {
            var addSalesFormModel = new AddSalesFormModel();


            List<Service> services = await _context.Services
            .AsNoTracking()
            .ToListAsync();

            addSalesFormModel.Services = services;

            return addSalesFormModel;
        }

        public async Task AddSales(AddSalesFormModel model)
        {
            var sales = new Promotion()
            {
                ServiceId = model.ServiceId,
                Price = model.Price,
                Description = model.Description,
            };

            await _context.Promotions.AddAsync(sales);
            await _context.SaveChangesAsync();
        }

        public async Task<List<SaleViewModel>> AllSales()
        {
            var allSales =
                await _context.Promotions
                .AsNoTracking()
                .Select(p => new SaleViewModel()
                {
                    Id = p.Id,
                    Service = p.Service,
                    Price = p.Price,
                    Description = p.Description,
                }).ToListAsync();

            return allSales;    
        }

        public async Task<ICollection<ServiceViewModel>> AllServices() 
        {
            var services =await _context.Services.AsNoTracking().Select(s => new ServiceViewModel
            {
                Id = s.Id,
                Price = s.Price,
                Name = s.Name,
                Description = s.Description,
            }).ToListAsync();

            return services;
        }

    }
}
