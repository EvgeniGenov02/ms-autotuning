using ms_autotuning.Infrastructior.Data;
using ms_autotuning.Infrastructior.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ms_autotuning.Core.Models.OrderViewsModels
{
    public class OrdersViewModel
    {
     
        public int Id { get; set; }

        public int ServiceId { get; set; }

        public Service Service { get; set; } = null!;

        public string Description { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = null!;

        public string Email { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!;
    }
}
