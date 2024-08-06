using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public string[] students;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        students = new string[]{"Shelley Benhoff", "Michael Irwin", "Ajeet Raina"};
    }

    public void OnGet()
    {

    }
}
