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

namespace ms_autotuning.Core.Services
{
    public class ServiceService : IServiceService
    {
        private readonly ApplicationDbContext _context;
        public ServiceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddReview(ReviewViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task AddReviews()
        {
            throw new NotImplementedException();
        }

        public Task AllReviews()
        {
            throw new NotImplementedException();
        }

        public Task AllSales()
        {
            throw new NotImplementedException();
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
