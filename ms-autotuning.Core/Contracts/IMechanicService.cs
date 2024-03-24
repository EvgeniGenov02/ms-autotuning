using ms_autotuning.Core.Models.MechanicViewsModels;

namespace ms_autotuning.Core.Contracts
{
    public interface IMechanicService
    {
        Task<List<MechanicGraphViewModel>> MechanicGraph();

        Task GetOrder(int id);

        Task CompleteOrder(int id);
    }
}
