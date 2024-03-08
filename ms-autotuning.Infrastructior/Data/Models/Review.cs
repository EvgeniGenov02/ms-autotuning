using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ms_autotuning.Infrastructior.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        //Service
        [Required]
        public int ServiceId { get; set; }

        [Required]
        [ForeignKey(nameof(ServiceId))]
        public Service Service { get; set; } = null!;

        //User
        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [MaxLength(DataConstants.ReviewConstants.RatingMax)]
        public int Rating { get; set; }

        [MaxLength(DataConstants.ReservationConstants.DescriptionMaxLength)]
        public string Feedback { get; set; } = string.Empty;

    }
}
