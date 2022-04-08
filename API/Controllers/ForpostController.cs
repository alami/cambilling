using API.Helpers;
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
//------------------------------------------
        [HttpGet("GetAccounts")]
        public async Task<ActionResult> GetAccountsAsync () { //GetAccounts
            ForpostReq tmp =new ForpostReq();            
            return Ok(await tmp.SendAsync("GetAccounts"));
        }        
        [HttpGet("GetUnavailableCameras")]
        public async Task<ActionResult> GetUnavailableCamerasAsync () { //GetAccounts
            ForpostReq fp =new ForpostReq();            
            var fpRez = await fp.SendAsync("GetUnavailableCameras");
            return Ok(fpRez);
        }        
    }
}