using ms_autotuning.Infrastructior.Data.Models;
using ms_autotuning.Infrastructior.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_autotuning.Core.Models.ServiceViewsModels
{
    public class ReviewFormModel
    {
        public int Id { get; set; }

        public int ServiceId { get; set; }
        public List<Service> Services { get; set; } 
        = new List<Service>();
 
        public string UserId { get; set; } = null!;

        public int Rating { get; set; }

        public string Feedback { get; set; } = string.Empty;
    }
}
