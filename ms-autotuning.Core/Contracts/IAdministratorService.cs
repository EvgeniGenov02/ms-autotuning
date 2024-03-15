using Microsoft.AspNetCore.Mvc;
using ms_autotuning.Core.Models.AdministratorViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_autotuning.Core.Contracts
{
    public interface IAdministratorService
    {
        Task EditService(EditServicesFormModel model);
        Task DelateReview(int id);

        Task DelateService(int id);

        Task DelateSale(int id);

        Task AddService(AddServiceFormModel model);

        Task AddMechanic(MechanicFormModel model);

        Task<ICollection<MechanicsViewModel>> AllMechanics();

        Task DeleteMechanic(int id);
    }
}
