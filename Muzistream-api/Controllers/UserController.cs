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

        [HttpGet("current")]
        public void GetCurrentUser()
        {

        }
    }
}
