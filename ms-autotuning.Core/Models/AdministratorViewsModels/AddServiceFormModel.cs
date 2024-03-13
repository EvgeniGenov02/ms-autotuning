using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_autotuning.Core.Models.AdministratorViewsModels
{
    public class AddServiceFormModel
    {
        public string Name { get; set; } = null!;

        public decimal Price { get; set; }
 
        public string Description { get; set; } = string.Empty;
    }
}
