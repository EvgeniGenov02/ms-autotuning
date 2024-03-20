using ms_autotuning.Infrastructior.Data.Models;

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
