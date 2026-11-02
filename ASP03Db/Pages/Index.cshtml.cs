using ASP03Db.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP03Db.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MovieDbContext _context;

        public IndexModel(
            ILogger<IndexModel> logger, 
            MovieDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            _logger.LogInformation("Index page accessed.");

        }
    }
}
