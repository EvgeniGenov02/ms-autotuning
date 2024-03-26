using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_autotuning.Infrastructior.Data.Models
{
    public class CompleteOrder
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [Required]
        [ForeignKey(nameof(ServiceId))]
        public Service Service { get; set; } = null!;

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public int MechanicId { get; set; }

        [Required]
        [ForeignKey(nameof(MechanicId))]
        public Mechanic Mechanic { get; set; } = null!;

    }
}
