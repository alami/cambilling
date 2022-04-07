using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BillingController : ControllerBase
    {
        private readonly ICambillingRepository _repo;
        public BillingController(ICambillingRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<ActionResult<List<Billing>>> GetBillings(){
            var billing = await _repo.GetBillingsAsync();
            return Ok(billing);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Billing>>  GetBilling(int id){
            var billing = await _repo.GetBillingByIdAsync(id);
            return Ok(billing);
        }
    }
}