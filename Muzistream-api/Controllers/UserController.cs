using Microsoft.AspNetCore.Mvc;

namespace Muzistream_api.Controllers
{
    [Route("api/User")]
    public class UserController : Controller
    {
        [HttpGet("{id}")]
        public void Get(string userReference)
        {
        }

        [HttpPost("connect")]
        public void Connect(string login, string password)
        {
            if (login == "" || password == "")
            {
                return ;
            }
            return ;
        }

        [HttpGet("community-code")]
        public string GetUserCommnityCode(string userReference) 
        {
            return "1901";
        }
    }
}
