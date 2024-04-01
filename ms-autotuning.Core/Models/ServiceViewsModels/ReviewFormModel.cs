using ms_autotuning.Infrastructior.Data.Models;
using ms_autotuning.Infrastructior.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ms_autotuning.Infrastructior.Data.DataConstants;

namespace ms_autotuning.Core.Models.ServiceViewsModels
{
    public class ReviewFormModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Полето за избор на услуга е задължително!")]
        public int ServiceId { get; set; }

        public List<Service> Services { get; set; } 
        = new List<Service>();
 
        public string UserId { get; set; } = null!;

        [Required(ErrorMessage = "Полето за рейтинг е задължително!")]
        public int Rating { get; set; }

        [MaxLength(ReviewConstants.Feedback , ErrorMessage = "Невалидна дължина, моля въведете съобщение до {0}")]
        public string? Feedback { get; set; } = String.Empty;
    }
}
