using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldWebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public string Name { get; set; } = string.Empty;
    public string Greeting { get; set; } = string.Empty;

    public void OnGet()
    {
        // runs when page first loads
    }

    public IActionResult OnPost()
    {
        if (!string.IsNullOrEmpty(Name))
        {
            Greeting = $"Hello, {Name}! Welcome to ASP.NET Core";
        }
        return Page();
    }
}
