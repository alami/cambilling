using Core.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using API.Helpers;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace Web.Pages;
[BindProperties]
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    [BindProperty]
    public IReadOnlyList<Camera> unavailableCameras { get; set; }
    public async Task<IActionResult> OnGet()
    {
        ForpostReq fp = new ForpostReq();
        var fpRez = await fp.SendAsync("GetUnavailableCameras");
        unavailableCameras = JsonSerializer.Deserialize<IReadOnlyList<Camera>>(fpRez);
        return Page();

    }
}
