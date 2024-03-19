using ms_autotuning.Core.Contracts;
using ms_autotuning.Core.Models.OrderViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_autotuning.Core.Services
{
    public class OrderService : IOrderService
    {
        public Task AllOrders()
        {
            throw new NotImplementedException();
        }

        public Task AllReservations()
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteReservation(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetOrder(OrdersViewModel order)
        {
            throw new NotImplementedException();
        }
    }
}
