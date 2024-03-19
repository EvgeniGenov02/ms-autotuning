using Microsoft.AspNetCore.Mvc;
using ms_autotuning.Core.Models.ServiceViewsModels;
using ms_autotuning.Infrastructior.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_autotuning.Core.Contracts
{
    public interface IServiceService
    {
        Task<List<ReviewViewModel>> AllReviews();

        Task AllSales();

        Task<ICollection<ServiceViewModel>> AllServices();

        Task AddReview(ReviewFormModel model);
        Task<ReviewFormModel> AddReview();
    }
}
