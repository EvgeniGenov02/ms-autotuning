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

        public async Task<List<OrdersViewModel>> AllOrders()
        {
            return await _context.Orders.Select(o => new OrdersViewModel()
            {
                Id = o.Id,
                ServiceId = o.ServiceId,
                Service = o.Service,
                Description = o.Description,
                PhoneNumber = o.User.PhoneNumber,
                Email = o.User.Email,
                User = o.User
            }).ToListAsync();

        }

        public async Task<List<ReservationViewModel>> AllReservations()
        {
            var userId = GetUserIdFromHttpContext();
            var user = await _context.Users.FindAsync(userId);
            var reservation = await _context.Reservations
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

        public async Task DeleteOrder(int id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id);

            if (order == null)
            {
                return;
            }

            _context.Orders.Remove(order);

            await _context.SaveChangesAsync();  
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
