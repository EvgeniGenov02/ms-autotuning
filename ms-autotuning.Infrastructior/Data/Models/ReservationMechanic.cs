using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ms_autotuning.Infrastructior.Data.Models
{
    public class ReservationMechanic
    {
        [Key]
        public int Id { get; set; }

        //Mechanic
        [Required]
        public int MechanicId { get; set; }

        [Required]
        [ForeignKey(nameof(MechanicId))]
        public Mechanic Mechanic { get; set; } = null!;

        //Reservation 
        [Required]
        public int ReservationId { get; set; }

        [Required]
        [ForeignKey(nameof(ReservationId))]
        public Reservation Reservation { get; set; } = null!;



    }
}
