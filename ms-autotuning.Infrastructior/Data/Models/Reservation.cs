﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ms_autotuning.Infrastructior.Data.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public Service Service { get; set; } = null!;

        [MaxLength(DataConstants.ReservationConstants.DescriptionMaxLength)]
        public string? Description { get; set; } = null;

        [Required]
        [Phone]
        [MaxLength(DataConstants.ReservationConstants.PhoneNumber)]
        public string PhoneNumber { get; set; } = null!;


        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
    }
}
