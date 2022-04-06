using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CambillingController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetTaskAsync () {

            return Ok('1');
        }
    }
}