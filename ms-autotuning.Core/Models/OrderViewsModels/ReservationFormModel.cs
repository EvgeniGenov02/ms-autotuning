using ms_autotuning.Infrastructior.Data;
using ms_autotuning.Infrastructior.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace ms_autotuning.Core.Models.OrderViewsModels
{
    public class ReservationFormModel
    {
        [Required(ErrorMessage = "Полето за избор на услуга е задължително!")]
        public int ServiceId { get; set; }
        public List<Service> Services { get; set; } = null!;

        [MaxLength(DataConstants.ReservationConstants.DescriptionMaxLength)]
        public string? Description { get; set; } = null;

        [Required(ErrorMessage = "Полето за телефонен номер е задължително!")]
        [Phone]
        [StringLength(DataConstants.ReservationConstants.PhoneNumber,
         MinimumLength = DataConstants.ReservationConstants.PhoneNumberMinLength,
         ErrorMessage = "Невалидна дължина на телефона, трябва да е между {2} и {1} синвола.")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;
    }
}
