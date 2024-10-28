using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment1_jp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        /// <summary>
        /// Acknowledges the secret integer.
        /// </summary>
        /// <param name="secret">The secret integer</param>
        /// <returns>A message acknowledging the secret</returns>
        /// <example>POST /api/q5/secret</example>
        [HttpPost("secret")]
        public string AcknowledgeSecret([FromBody] int secret)
        {
            return $"Shh.. the secret is {secret}";
        }
    }
}
