using Microsoft.AspNetCore.Mvc;

namespace ms_autotuning.Components
{
    public class ContactForm : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View("ContactForm"));
        }
    }
}
