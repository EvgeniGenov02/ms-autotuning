using ms_autotuning.Infrastructior.Data.Models;
using System.ComponentModel.DataAnnotations;
using static ms_autotuning.Infrastructior.Data.DataConstants;

namespace ms_autotuning.Core.Models.AdministratorViewsModels
{
    public class AddSalesFormModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Полето за име на услуга е задължително!")]
        public int ServiceId { get; set; }

        [Required]
        public List<Service> Services { get; set; } = null!;

        [Required(ErrorMessage = "Полето за цена на услуга е задължително!")]
        [RegularExpression(PromotionConstants.RegularExpressionForPrice
        , ErrorMessage = "Невалидна цена. Трябва да е число.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Полето за описание на услуга е задължително!")]
        [StringLength(PromotionConstants.DescriptionMaxLength,
         MinimumLength = PromotionConstants.DescriptionMinLength
            , ErrorMessage = "Невалидна дължина на описанието, трябва да е между {2} и {1} синвола.")]
        public string Description { get; set; } = null!;
    }
}
