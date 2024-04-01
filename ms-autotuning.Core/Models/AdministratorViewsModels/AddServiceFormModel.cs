using System.ComponentModel.DataAnnotations;
using static ms_autotuning.Infrastructior.Data.DataConstants;


namespace ms_autotuning.Core.Models.AdministratorViewsModels
{
    public class AddServiceFormModel
    {
        [Required(ErrorMessage = "Полето за име на услуга е задължително!")]
        [StringLength(ServiceConstants.NameMaxLength,
      MinimumLength = ServiceConstants.NameMinLength,
      ErrorMessage = "Невалидна дължина на името, трябва да е между {2} и {1} синвола.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Полето за цена на услуга е задължително!")]

        [RegularExpression(ServiceConstants.RegularExpressionForPrice
         , ErrorMessage = "Невалидна цена. Трябва да е число.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Полето за описание на услуга е задължително!")]
        [StringLength(ServiceConstants.DescriptionMaxLength,
      MinimumLength = ServiceConstants.DescriptionMinLength,
      ErrorMessage = "Невалидна дължина на описанието, трябва да е между {2} и {1} синвола.")]
        public string Description { get; set; } = string.Empty;
    }
}
