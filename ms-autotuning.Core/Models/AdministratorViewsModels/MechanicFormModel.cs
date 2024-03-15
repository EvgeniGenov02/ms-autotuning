using System.ComponentModel.DataAnnotations;

namespace ms_autotuning.Core.Models.AdministratorViewsModels
{
    public class MechanicFormModel
    {
        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;
    }
}
