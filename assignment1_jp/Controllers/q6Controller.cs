using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment1_jp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        /// <summary>
        /// Calculates the area of a regular hexagon with side length S.
        /// </summary>
        /// <param name="side">The side length of the hexagon</param>
        /// <returns>The area of the hexagon</returns>
        /// <example>GET /api/q6/hexagon?side=1</example>
        [HttpGet("hexagon")]
        public double GetHexagonArea([FromQuery] double side)
        {
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
        }
    }
}
