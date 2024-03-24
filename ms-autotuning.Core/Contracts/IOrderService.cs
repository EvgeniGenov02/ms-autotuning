using Microsoft.AspNetCore.Mvc;
using ms_autotuning.Core.Models.OrderViewsModels;
using ms_autotuning.Core.Models.ServiceViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_autotuning.Core.Contracts
{
    public interface IOrderService
    {
        Task AddReservation(ReservationFormModel model);
        Task<ReservationFormModel> AddReservation();

        Task<List<ReservationViewModel>> AllReservations();

        Task<List<OrdersViewModel>> AllOrders();

        Task DeleteOrder(int id);

        Task DeleteReservation(int id);
    }
}
