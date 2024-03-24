using Microsoft.AspNetCore.Identity;
using ms_autotuning.Core.Contracts;
using ms_autotuning.Core.Models.MechanicViewsModels;
using ms_autotuning.Infrastructior.Data.Models;
using ms_autotuning.Infrastructior.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Documents;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ms_autotuning.Core.Services
{
    public class MechanicService : IMechanicService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public MechanicService(ApplicationDbContext context,
             UserManager<ApplicationUser> userManager,
            IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
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


        public async Task CompleteOrder(int id)
        {
            var userId = GetUserIdFromHttpContext();

            var mechanic = await _context.Mechanics
                .FirstOrDefaultAsync(m => m.User.Id == userId);

            if(mechanic == null)
            {
                return;
            }

            var order =  await _context.Orders.FirstOrDefaultAsync(o => o.Id == id);

            if(order == null || order.User.Id != userId)
            {
                return;
            }

            _context.Orders.Remove(order);

           await _context.SaveChangesAsync();

        }

        public async Task GetOrder(int id)
        {
            var reservation = await _context.Reservations.FirstOrDefaultAsync(r => r.Id == id);

            if (reservation == null)
            {
                return;
            }

            var userId = GetUserIdFromHttpContext();

            if (userId == null)
            {
                return;
            }

            var mechanic = await _context.Mechanics.FirstOrDefaultAsync(m => m.User.Id == userId);

            if (mechanic == null)
            {
                return;
            }

            var order = await _context.Orders.AddAsync(new Order()
            {
                ServiceId = reservation.ServiceId,
                Description = reservation.Description,
                UserId = userId,
                MechanicId = mechanic.Id,
            });

            _context.Reservations.Remove(reservation);

            await _context.SaveChangesAsync();
        }
        
        public async Task<List<MechanicGraphViewModel>> MechanicGraph()
        {
           var userId = GetUserIdFromHttpContext();

            if(userId == null)
            {
                return null;
            }

            var mechanic = await _context.Mechanics.FirstOrDefaultAsync(m => m.UserId == userId);

            if (mechanic == null)
            {
                return null;
            }

            return await _context.Orders
                .Where(o => o.MechanicId == mechanic.Id)
                .Select(o => new MechanicGraphViewModel()
                {
                    Id = o.Id,
                    Description = o.Description,
                    Service = o.Service,
                    PhoneNumber = o.User.PhoneNumber,
                    Email = o.User.Email,
                    UserName = o.User.UserName,
                    User = o.User
                })
                .ToListAsync();

        }
    }
}
