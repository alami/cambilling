using Microsoft.AspNetCore.Mvc;
using Core.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using API.Helpers;
using System.Text.Json;

namespace Web.Pages
{
    public class AccountsModel : PageModel
    {
        public List<ForpostAccount> forpostAccounts { get; set; }
        public async Task<IActionResult> OnGet()
        {
            ForpostReq fp = new ForpostReq();
            var fpRez = await fp.SendAsync("GetAccounts");
            forpostAccounts = JsonSerializer.Deserialize<List<ForpostAccount>>(fpRez);
            return Page();
        }
    }
}
