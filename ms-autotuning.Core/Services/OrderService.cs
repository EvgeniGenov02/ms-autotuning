using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ms_autotuning.Core.Contracts;
using ms_autotuning.Core.Models.OrderViewsModels;
using ms_autotuning.Infrastructior.Data.Models;
using ms_autotuning.Infrastructior.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ms_autotuning.Core.Models.ServiceViewsModels;
using Microsoft.Azure.Documents;

namespace ms_autotuning.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public OrderService(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task AddReservation(ReservationFormModel model)
        {
            var userId = GetUserIdFromHttpContext();
            var reservation = new Reservation()
            {
                ServiceId = model.ServiceId,
                Description = model.Description,
                PhoneNumber = model.PhoneNumber,
                UserId = userId,
            };

            await _context.Reservations.AddAsync(reservation);
            await _context.SaveChangesAsync();
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

        public async Task<ReservationFormModel> AddReservation()
        {
            var reservationFormModel = new ReservationFormModel();


            List<Service> services = await _context.Services
            .AsNoTracking()
            .ToListAsync();

            reservationFormModel.Services = services;

            return reservationFormModel;
        }

        public Task AllOrders()
        {
            throw new NotImplementedException();
        }

        public async Task<List<ReservationViewModel>> AllReservations()
        {
            var userId = GetUserIdFromHttpContext();
            var user = await _context.Users.FindAsync(userId);
            var reservation = await _context.Reservations
                .Where(r => r.UserId == userId)
                .Select(r => new ReservationViewModel()
                {
                    Id = r.Id,
                    Service = r.Service,
                    Description = r.Description,
                    PhoneNumber = r.PhoneNumber,
                    Email = user.Email,
                    UserName = user.UserName,
                    User = user,
                }).ToListAsync();

            return reservation;
        }

        public Task DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteReservation(int id)
        {
            var userId = GetUserIdFromHttpContext();
            var reservation = await _context.Reservations.FirstOrDefaultAsync(r => r.Id == id);

            if (reservation == null)
            {
                return;
            }

            if(reservation.User.Id != userId)
            {
                return;
            }
            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
        }
    }
}
