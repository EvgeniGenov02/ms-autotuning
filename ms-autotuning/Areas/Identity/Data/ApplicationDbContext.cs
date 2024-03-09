using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ms_autotuning.Infrastructior.Data.Models;

namespace ms_autotuning.Infrastructior.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Administrator>? Administrators { get; set; }
        public DbSet<Mechanic>? Mechanics { get; set; }
        public DbSet<Promotion>? Promotions { get; set; }
        public DbSet<Reservation>? Reservations { get; set; }
        public DbSet<Review>? Reviews { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<ReservationMechanic>? ReservationsMechanics { get; set; }

    }
}