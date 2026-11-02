using ASP03Db.Data;
using ASP03Db.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP03Db.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MovieDbContext _context;

        public CreateModel(ILogger<IndexModel> logger, MovieDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [BindProperty]
        public Movie? Input { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Invalid model state for movie creation.");
                return Page();
            }
            try
            {
                _context.Movies.Add(Input!);
                _context.SaveChanges();
                _logger.LogInformation("Movie '{Title}' created successfully.", Input!.Title);
                return RedirectToPage("/Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating movie '{Title}'.", Input?.Title);
                ModelState.AddModelError(string.Empty, "An error occurred while creating the movie.");
                return Page();
            }
        }
    }
}
