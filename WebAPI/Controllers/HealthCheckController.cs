using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

public class HealthCheckController : Controller
{
    // GET
    [HttpGet]
    [Route("api/[controller]")]
    public IActionResult Index()
    {
        return NoContent();
    }
}