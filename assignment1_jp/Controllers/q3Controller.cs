using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment1_jp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        /// <summary>
        /// Returns the cube of the given integer.
        /// </summary>
        /// <param name="base">The base integer</param>
        /// <returns>The cube of the base integer</returns>
        /// <example>GET /api/q3/cube/4</example>
        [HttpGet("cube/{base}")]
        public int GetCube(int @base)
        {
            return @base * @base * @base;
        }
    }
}
