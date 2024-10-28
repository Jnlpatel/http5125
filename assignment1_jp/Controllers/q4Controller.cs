using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment1_jp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {
        /// <summary>
        /// Starts a knock-knock joke.
        /// </summary>
        /// <returns>Who’s there?</returns>
        /// <example>POST /api/q4/knockknock</example>
        [HttpPost("knockknock")]
        public string StartJoke()
        {
            return "Who’s there?";
        }
    }
}
