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
        [HttpGet("todos")]
        public async Task<ActionResult> GetTaskAsync () {
            string url = "https://jsonplaceholder.typicode.com/todos/";
            try {
                WebRequest request = WebRequest.Create(url);
                request.Credentials = new NetworkCredential("myLogin", "myPassword");
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
            return Ok(url);
        }
        [HttpPost]
        public async Task<ActionResult> PostTaskAsync () { //GetUnavailableCameras
            string url = "https://ipcam.uzcloud.uz/system-api/GetUnavailableCameras";
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.Headers.Add("Authorization", "Basic Og==");
            request.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

            string data = "";
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
                    
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
        
            WebResponse response = await request.GetResponseAsync();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    return Ok(reader.ReadToEnd());
                }
            }
            response.Close();            

            return Ok("Запрос выполнен...");
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