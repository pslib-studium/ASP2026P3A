using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP01Routing.Pages
{
    public class SecondModel : PageModel
    {
        [BindProperty(SupportsGet = true)] // This attribute allows the property to be bound from query parameters in GET requests.
        public int Value { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Change { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnGetIncrease()
        {
            Value++;
            return Page();
        }
        public void OnGetDecrease()
        {
            Value--;
        }
        public void OnGetAdd()
        {
            Value = Value + Change;
        }
    }
}
