using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CambillingController : ControllerBase
    {
        static HttpClient client = new HttpClient();
        private readonly ICambillingRepository _repo;
        public CambillingController(ICambillingRepository repo)
        {
            _repo = repo;
        }
        [HttpGet("UnaccessibleCameras")]
        public async Task<ActionResult> GetTaskAsync () {

            return Ok('1');
        }
        [HttpGet]
        public async Task<ActionResult<List<Cambilling>>> GetCambillings(){
            var cambillings = await _repo.GetCambillingsAsync();
            return Ok(cambillings);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Cambilling>>  GetCambilling(int id){
            var cambilling = await _repo.GetCambillingByIdAsync(id);
            return Ok(cambilling);
        }
    }
}