using Microsoft.AspNetCore.Mvc;

namespace Muzistream_api.Controllers
{
    [Route("api/User")]
    public class TokenController : Controller
    {        
        [HttpGet("check")]
        public bool Check(string token)
        {
            var exist = true;
            return exist;
        }

        
    }
}
