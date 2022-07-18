using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace SimpleEmailApp.Controllers;

[Route("api/{controller}")]
[ApiController]
public class EmailController : ControllerBase
{
    [HttpPost]
    public IActionResult SendEmail(string body)
    {
        

        return Ok();
    }
}