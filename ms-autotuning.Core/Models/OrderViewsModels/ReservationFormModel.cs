using ms_autotuning.Infrastructior.Data.Models;

namespace ms_autotuning.Core.Models.OrderViewsModels
{
    public class ReservationFormModel
    {
        public int ServiceId { get; set; } 
        public List<Service> Services { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;
        public string UserId { get; set; } = null!;
    }
}
