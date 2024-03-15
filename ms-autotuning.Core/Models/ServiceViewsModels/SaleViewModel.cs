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
    public class SaleViewModel
    {
        public int Id { get; set; }

        public Service Service { get; set; } = null!;

        public decimal Price { get; set; }

        public string Description { get; set; } = null!;
    }
}
