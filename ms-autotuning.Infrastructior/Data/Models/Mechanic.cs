using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ms_autotuning.Infrastructior.Data.Models
{
    public class Mechanic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Phone]
        [MaxLength(DataConstants.MechanicConstants.PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
    }
}
