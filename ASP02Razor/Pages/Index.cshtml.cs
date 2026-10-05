using ASP02Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP02Razor.Pages
{
    public class IndexModel : PageModel
    {
        public List<Human> Humans { get; set; } = new List<Human>
        {
            new Human { HumanId = 1, Name = "Alice", Gender = Gender.Female },
            new Human { HumanId = 2, Name = "Bob", Gender = Gender.Male },
            new Human { HumanId = 3, Name = "Charlie", Gender = Gender.Other },
            new Human { HumanId = 4, Name = "Dana", Gender = Gender.Unknown },
            new Human { HumanId = 5, Name = "Eve", Gender = Gender.Whocares }
        };
        public void OnGet()
        {

        }
    }
}
