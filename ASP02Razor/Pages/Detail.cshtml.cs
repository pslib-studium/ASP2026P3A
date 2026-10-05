using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP02Razor.Pages
{
    public class DetailModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Name { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrEmpty(Name))
            {
                ViewData["Title"] = "?";
            }
            else
            {
                ViewData["Title"] = Name;
            }
        }
    }
}
