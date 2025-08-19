using DND_Initiative_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace DND_Initiative_Tracker.Controllers
{
    [ApiController]
    [Route("api/health")]
    public class HealthController(ILogger<UserController> _logger) : ControllerBase
    {


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new {status = "Healty", timestamp = DateTime.Now});

        }

    }
}
