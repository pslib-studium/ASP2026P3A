using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP01Routing.Pages
{
    public class FirstModel : PageModel // This class represents the model for the "First" Razor Page
                                        // PageModel je těsně spojen s Razor Page a poskytuje data a logiku pro stránku. Obsahuje metody pro zpracování HTTP požadavků (např. GET, POST)
                                        // a vlastnosti pro uchovávání dat, která budou použita v Razor Page.
    {
        public int Value { get; set; } = 0; // bound property, která uchovává hodnotu, která bude použita v Razor Page. Inicializována na 0.
                                            // bindovat bez atributu jdou jen vlastnosti předávané jako GET parametry, POST parametry a route parametry. Vlastnosti, které nejsou bindovány, se musí explicitně nastavit v metodách OnGet, OnPost atd.

        // https://localhost:7232/first?val=4 // val je query parameter
        // https://localhost:7232/first?val=4&name=Alois
        public void OnGet() // handler
            // metody HTTP: GET, POST, ...
        {
            Value = 0;
        }

        public void OnPost()
        {
            // pro odeslání dat metodou POST z formuláře
        }

        public void OnGetSet(int val) // pojmenovaný handler GET pro volání ?handler=set
                                      // https://localhost:7232/first?handler=set&val=8
        {
            Value = val;
        }

        public void OnGetIncrease()
        {
            Value = Value + 1;
        }
    }
}
