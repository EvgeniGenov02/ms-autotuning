using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ms_autotuning.Infrastructior.Data.Models
{
    public class Mechanic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.MechanicConstants.NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        public IEnumerable<Reservation> Reservations { get; init; }
       = new List<Reservation>();
    }
}
