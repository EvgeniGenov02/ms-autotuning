﻿using Microsoft.AspNetCore.Mvc;
using ms_autotuning.Core.Models.ServiceViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_autotuning.Core.Contracts
{
    public interface IServiceService
    {
        Task AllReviews();

        Task AllSales();

        Task<ICollection<ServiceViewModel>> AllServices();

        Task AddReviews();

        Task AddReview(ReviewViewModel model);
    }
}
