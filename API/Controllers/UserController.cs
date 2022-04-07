using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ICambillingRepository _repo;
        public UserController(ICambillingRepository repo)
        {
            _repo = repo;
        }
//-------------------------------------------
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers(){
            var users = await _repo.GetUsersAsync();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<User>>  GetUser(int id){
            var user = await _repo.GetUserByIdAsync(id);
            return Ok(user);
        }
    }
}