using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ms_autotuning.Infrastructior.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(DataConstants.OrderConstants.DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public Service Service { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public int MechanicId { get; set; }
    }
}
