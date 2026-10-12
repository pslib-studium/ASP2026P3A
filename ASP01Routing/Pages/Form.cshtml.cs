using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ASP01Routing.Pages
{
    public class FormModel : PageModel
    {
        [BindProperty] // binduje se POST
        public SubscriptionIM? Input { get; set; }
        public void OnGet()
        {
            Input = new SubscriptionIM { Name = "John Doe", Email = "jd@test.test" };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // pokud neprojde validace, znovu zobrazíme formulář s chybovými hláškami
                return Page();
            }
            // zpracování formuláře, např. uložení do databáze nebo odeslání emailu
            // pokud je model validní, přesměrujeme na stránku Success a předáme parametry
            return RedirectToPage("Success", new { name = Input?.Name, email = Input?.Email });
        }
    }

    public class SubscriptionIM // DTO pro lepší organizaci dat z formuláře, obsahuje validace pro jednotlivé vlastnosti
    {
        [Required(ErrorMessage = "Jméno musí být vyplněno")]
        [Display(Name="Jméno")]
        [MinLength(3, ErrorMessage = "Jméno musí být delší než 3 znaky")]
        public required string Name { get; set; }
        [Required, EmailAddress, Display(Name="Emailová adresa")]
        public required string Email { get; set; }
    }
}
