using ASP02Razor.Models;
using ASP02Razor.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP02Razor.Pages
{
    public class DetailModel : PageModel
    {
        private readonly ILogger<DetailModel> _logger;
        private readonly DataProviderService _dataProviderService;
        private List<Human> Humans => _dataProviderService.Humans;

        public DetailModel(ILogger<DetailModel> logger, DataProviderService dataProviderService)
        {
            _logger = logger;
            _dataProviderService = dataProviderService;
            Text = _dataProviderService.Text.ToString();
        }

        [BindProperty(SupportsGet = true)]
        public int? Id { get; set; }
        public string Text { get; set; }
        public Human? Item { get; set; }
        public void OnGet()
        {
            if (Id == null)
            {
                ViewData["Title"] = "?";
            }
            else
            {
                Item = Humans.FirstOrDefault(h => h.HumanId == Id);
                if (Item == null)
                {
                    ViewData["Title"] = "404";
                }
                else
                {
                    ViewData["Title"] = Item?.Name ?? "?";
                }
            }
        }
    }
}
