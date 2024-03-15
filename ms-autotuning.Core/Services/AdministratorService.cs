using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using ms_autotuning.Core.Contracts;
using ms_autotuning.Core.Models.AdministratorViewsModels;
using ms_autotuning.Infrastructior.Data;
using ms_autotuning.Infrastructior.Data.Models;
using System.Xml.Linq;

namespace ms_autotuning.Core.Services
{
    public class AdministratorService : IAdministratorService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserStore<ApplicationUser> _userStore;

        public AdministratorService(ApplicationDbContext context,
              UserManager<ApplicationUser> userManager,
              IUserStore<ApplicationUser> userStore)
        {
            _context = context;
            _userManager = userManager;
            _userStore = userStore;

        }

        public async Task AddMechanic(MechanicFormModel model)
        {

            var user  = new ApplicationUser()
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            await _userStore.SetUserNameAsync(user, model.Email, CancellationToken.None);
            await _userManager.CreateAsync(user, model.Password);

            var entity = new Mechanic()
            {
                PhoneNumber = model.PhoneNumber,
                User = user
            };

            await _context.Mechanics.AddAsync(entity); 

            await _context.SaveChangesAsync();
        }
        public async Task<ICollection<MechanicsViewModel>> AllMechanics()
        {
            var mechanics = await _context.Mechanics.AsNoTracking().Select(m => new MechanicsViewModel
            {
                Id = m.Id,
                FirstName = m.User.FirstName,
                LastName = m.User.LastName,
                Email = m.User.Email,
                PhoneNumber = m.User.PhoneNumber,
            }).ToListAsync();

            return mechanics;
        }
        public async Task DeleteMechanic(int id)
        {
            var mechanic = await _context.Mechanics.FirstOrDefaultAsync(m => m.Id == id);
            if(mechanic == null)
            {
                return;
            }

            var user = _context.Users.Find(mechanic.UserId);

            if (user == null)
            {
                return;
            } 
            _context.Users.Remove(user);
            _context.Mechanics.Remove(mechanic);
            _context.SaveChanges();
        }
        public async Task AddService(AddServiceFormModel serviceFormModel)
        {
            var service = new Service()
            {
                Name = serviceFormModel.Name,
                Price = serviceFormModel.Price,
                Description = serviceFormModel.Description
            };

            await _context.Services.AddAsync(service);

            await _context.SaveChangesAsync();
        }

        public Task DelateReview(int id)
        {
            throw new NotImplementedException();
        }

        public Task DelateSale(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DelateService(int id)
        {
            var service = await _context.Services.FirstOrDefaultAsync(s => s.Id == id);

            if (service == null)
            {
                return;
            }

            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
        }

        public Task EditService(EditServicesFormModel model)
        {
            throw new NotImplementedException();
        }
    }
}
