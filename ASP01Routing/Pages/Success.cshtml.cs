using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP01Routing.Pages
{
    public class SuccessModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Name { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? Email { get; set; }
        public void OnGet()
        {
        }
    }
}
