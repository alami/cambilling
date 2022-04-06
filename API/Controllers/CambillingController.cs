using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CambillingController : ControllerBase
    {
        private readonly ICambillingRepository _repo;
        public CambillingController(ICambillingRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<ActionResult> GetTaskAsync () {

            return Ok('1');
        }
        [HttpGet("billings/{id}")]
        public async Task<ActionResult<Billing>>  GetBilling(int id){
            var billing = await _repo.GetBillingByIdAsync(id);
            return Ok(billing);
        }
        [HttpGet("billings")]
        public async Task<ActionResult<List<Billing>>> GetBillings(){
            var billing = await _repo.GetBillingsAsync();
            return Ok(billing);
        }
        [HttpGet("users/{id}")]
        public async Task<ActionResult<User>>  GetUser(int id){
            var user = await _repo.GetUserByIdAsync(id);
            return Ok(user);
        }
        [HttpGet("users")]
        public async Task<ActionResult<List<User>>> GetUsers(){
            var users = await _repo.GetUsersAsync();
            return Ok(users);
        }
    }
}