using Microsoft.AspNetCore.Mvc;
using ms_autotuning.Core.Models.OrderViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_autotuning.Core.Contracts
{
    public interface IOrderService
    {
        Task AllReservations();

        Task AllOrders();

        Task GetOrder(OrdersViewModel order);

        Task DeleteOrder(int id);

        Task DeleteReservation(int id);
    }
}
