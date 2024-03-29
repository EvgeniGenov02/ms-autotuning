﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_autotuning.Core.Models.AdministratorViewsModels
{
    public class EditServicesFormModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}
