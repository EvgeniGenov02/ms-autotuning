using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace ms_autotuning.Infrastructior.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(DataConstants.ApplicationUserConstants.FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(DataConstants.ApplicationUserConstants.LastNameMaxLength)]
        public string LastName { get; set; } = null!;
    }
}
