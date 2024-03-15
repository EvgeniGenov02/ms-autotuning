using ms_autotuning.Infrastructior.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_autotuning.Core.Models.ServiceViewsModels
{
    public class ReviewViewModel
    {

        public int Id { get; set; }

        public int ServiceId { get; set; }

        public Service Services { get; set; } = null!;

        public string UserId { get; set; } = null!;

        public int Rating { get; set; }

        public string Feedback { get; set; } = string.Empty;
    }
}
