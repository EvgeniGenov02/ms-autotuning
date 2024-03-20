using ms_autotuning.Core.Models.AdministratorViewsModels;
using ms_autotuning.Core.Models.ServiceViewsModels;

namespace ms_autotuning.Core.Contracts
{
    public interface IServiceService
    {
        Task<List<ReviewViewModel>> AllReviews();

        Task<List<SaleViewModel>> AllSales();

        Task<ICollection<ServiceViewModel>> AllServices();

        Task AddReview(ReviewFormModel model);
        Task<ReviewFormModel> AddReview();

        Task<AddSalesFormModel> AddSales();

        Task AddSales(AddSalesFormModel model);
    }
}
