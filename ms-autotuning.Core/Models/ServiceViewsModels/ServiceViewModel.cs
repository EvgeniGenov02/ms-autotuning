namespace ms_autotuning.Core.Models.ServiceViewsModels
{
    public class ServiceViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}
