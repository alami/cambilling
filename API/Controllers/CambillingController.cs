using Core.Entities;
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
        // HttpGet("Users")]
        // public async Task<ActionResult<List<User>>> GetUsers(){
        //     return Ok(await _UserRepo.ListAllAsync());            
        // }
    }
}