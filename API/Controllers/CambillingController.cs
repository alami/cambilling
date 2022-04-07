using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
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

 try {
    WebRequest request = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/");
    using (WebResponse response = request.GetResponse())  {
        using (Stream stream = response.GetResponseStream())  {
            using (StreamReader reader = new StreamReader(stream)) {
                return Ok(reader.ReadToEnd());
            }
        }
    }
} catch(WebException ex) {
    // получаем статус исключения
    WebExceptionStatus status = ex.Status; 
    if (status == WebExceptionStatus.ProtocolError)  {
        HttpWebResponse httpResponse = (HttpWebResponse)ex.Response;
        return Ok("Статусный код ошибки: "+ex.Message);
    }
}
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