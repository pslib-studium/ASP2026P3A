using ASP02Razor.Models;
using ASP02Razor.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP02Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DataProviderService _dataProviderService;
        public IndexModel(ILogger<IndexModel> logger, DataProviderService dataProviderService)
        {
            // služby připojené přes dependency injection
            _logger = logger;
            _dataProviderService = dataProviderService;
            Text = _dataProviderService.Text.ToString();
            Humans = _dataProviderService.Humans;
        }

        public string Text { get; set; }
        public List<Human> Humans { get; set; }
        public void OnGet()
        {
            _logger.LogDebug("Get");
        }
    }
}
