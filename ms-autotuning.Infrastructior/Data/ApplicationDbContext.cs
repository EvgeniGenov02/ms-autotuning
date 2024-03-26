using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ms_autotuning.Infrastructior.Data.Models;
using System.Security.Cryptography;
using System.Text;

namespace ms_autotuning.Infrastructior.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            var adminRole = new ApplicationRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Admin",
                NormalizedName = "Admin".ToUpper(),
                BGName = "Администратор"
            };



            var adminUser = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true, 
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = "Администратор",
                LastName = ""
            };

            var passwordHasher = new PasswordHasher<ApplicationUser>();
            var hashedPassword = passwordHasher.HashPassword(adminUser, "123456");
            adminUser.PasswordHash = hashedPassword;

            modelBuilder.Entity<ApplicationRole>().HasData(adminRole);
            modelBuilder.Entity<ApplicationUser>().HasData(adminUser);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRole.Id,
                    UserId = adminUser.Id
                }
            );
        }

        public DbSet<Mechanic>? Mechanics { get; set; }
        public DbSet<Promotion>? Promotions { get; set; }
        public DbSet<Reservation>? Reservations { get; set; }
        public DbSet<Review>? Reviews { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<Order>? Orders { get; set; }


    }
}