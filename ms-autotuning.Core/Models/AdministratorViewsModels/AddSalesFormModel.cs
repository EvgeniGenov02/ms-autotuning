using ms_autotuning.Infrastructior.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace ms_autotuning.Core.Models.AdministratorViewsModels
{
    public class AddSalesFormModel
    {
        public int Id { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [Required]
        public List<Service> Services { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; } = null!;
    }
}
