using ms_autotuning.Infrastructior.Data.Models;

namespace ms_autotuning.Core.Models.OrderViewsModels
{
    public class ReservationViewModel
    {
        public int Id { get; set; }
        public Service Service { get; set; } = null!;

        public string Description { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!;
    }
}
