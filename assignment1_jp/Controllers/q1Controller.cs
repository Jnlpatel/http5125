using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment1_jp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {
        /// <summary>
        /// Returns a welcome message.
        /// </summary>
        /// <returns>Welcome to 5125!</returns>
        /// <example>GET /api/q1/welcome</example>
        [HttpGet(template:"welcome")]
        public string welcome()
        {
            return "Welcome to 5125!";
        }
    }
}
