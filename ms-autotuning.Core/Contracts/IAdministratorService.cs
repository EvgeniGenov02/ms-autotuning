using Microsoft.AspNetCore.Mvc;
using ms_autotuning.Core.Models.AdministratorViewsModels;
using ms_autotuning.Infrastructior.Data.Models;


namespace ms_autotuning.Core.Contracts
{
    public interface IAdministratorService
    {
        Task<EditServicesFormModel> GetService(int id);
        Task EditService(EditServicesFormModel editServicesFormModel);
        Task DelateService(int id);

        Task DelateSale(int id);

        Task AddService(AddServiceFormModel model);

        Task AddMechanic(MechanicFormModel model);

        Task<ICollection<MechanicsViewModel>> AllMechanics();
        Task<ICollection<CompleteOrdersViewModel>> CompleteOrders(string? name);

        Task DeleteMechanic(int id);
    }
}
