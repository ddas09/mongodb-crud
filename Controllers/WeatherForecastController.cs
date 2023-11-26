using Microsoft.AspNetCore.Mvc;

namespace MongoDB.CRUD.API.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Server is working");
    }
}
