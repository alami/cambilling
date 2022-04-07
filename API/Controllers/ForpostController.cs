using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ForpostController : ControllerBase
    {
        private readonly ICambillingRepository _repo;
        public ForpostController(ICambillingRepository repo)
        {
            _repo = repo;
        }
//-------------------------------------------
        [HttpGet]
        public async Task<ActionResult<List<Forpost>>> GetForposts(){
            var forposts = await _repo.GetForpostsAsync();
            return Ok(forposts);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Forpost>>  GetForpost(int id){
            var forpost = await _repo.GetForpostByIdAsync(id);
            return Ok(forpost);
        }
    }
}