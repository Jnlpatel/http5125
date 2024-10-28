using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment1_jp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        /// <summary>
        /// Returns a personalized greeting message.
        /// </summary>
        /// <param name="name">The name of the person</param>
        /// <returns>A greeting message to the specified name</returns>
        /// <example>GET /api/q2/greeting?name=Gary</example>
        [HttpGet("greeting")]
        public string GetGreeting([FromQuery] string name)
        {
            return $"Hi {name}!";
        }
    }
}
