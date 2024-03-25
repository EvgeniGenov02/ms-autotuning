using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static ms_autotuning.Infrastructior.Data.DataConstants;

namespace ms_autotuning.Infrastructior.Data.Models
{
    public class ApplicationRole : IdentityRole
    {
        [MaxLength(ApplicationApplicationRole.BGNameMaxLength)]
        public string? BGName { get; set; }
    }
}
