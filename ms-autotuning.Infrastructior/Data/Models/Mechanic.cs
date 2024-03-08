using System.ComponentModel.DataAnnotations;

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
        public string User { get; set; } = null!;
    }
}
