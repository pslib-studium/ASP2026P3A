using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP01Routing.Pages
{
    public class FirstModel : PageModel // This class represents the model for the "First" Razor Page
                                        // PageModel je těsně spojen s Razor Page a poskytuje data a logiku pro stránku. Obsahuje metody pro zpracování HTTP požadavků (např. GET, POST)
                                        // a vlastnosti pro uchovávání dat, která budou použita v Razor Page.
    {
        public string Value { get; set; } = string.Empty;
        public void OnGet()
        {
            Value = "Tonda";
        }
    }
}
