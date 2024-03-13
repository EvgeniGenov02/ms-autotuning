using System.ComponentModel.DataAnnotations;

namespace ms_autotuning.Infrastructior.Data.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.ServiceConstants.NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(DataConstants.ServiceConstants.DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;
    }
}
