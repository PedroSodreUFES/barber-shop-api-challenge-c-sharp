using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetUser([FromRoute]int id)
    {
        // Placeholder logic to get a user by ID
        var user = new { Id = id, Name = $"Cleiton-{id}" };
        return Ok(user);
    } 
}
