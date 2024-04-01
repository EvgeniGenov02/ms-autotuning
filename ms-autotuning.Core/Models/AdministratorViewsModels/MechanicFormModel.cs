using ms_autotuning.Infrastructior.Data;
using System.ComponentModel.DataAnnotations;

namespace ms_autotuning.Core.Models.AdministratorViewsModels
{
    public class MechanicFormModel
    {
        [Required(ErrorMessage = "Полето за име е задължително!")]
        [StringLength(DataConstants.MechanicConstants.NameMaxLength,
      MinimumLength = DataConstants.MechanicConstants.NameMinLength,
      ErrorMessage = "Невалидна дължина на име, трябва да е между {2} и {1} синвола.")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Полето за фамилия е задължително!")]
        [StringLength(DataConstants.MechanicConstants.LastNameMaxLength,
    MinimumLength = DataConstants.MechanicConstants.LastNameMinLength,
    ErrorMessage = "Невалидна дължина на фамилия, трябва да е между {2} и {1} синвола.")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Полето за имейл е задължително!")]
        [EmailAddress(ErrorMessage = "Невалиден имейл!")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Полето за парола е задължително!")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Полето за телафон е задължително!")]
        [Phone(ErrorMessage = "Невалиден  телефонен номер")]

        public string PhoneNumber { get; set; } = null!;
    }
}
