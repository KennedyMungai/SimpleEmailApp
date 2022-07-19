using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace SimpleEmailApp.Controllers;

[Route("api/{controller}")]
[ApiController]
public class EmailController : ControllerBase
{
    private readonly IEmailService EmailService;

    public EmailController(IEmailService EmailService)
    {
        this.EmailService = EmailService;
    }

    [HttpPost]
    public IActionResult SendEmail(EmailDto request)
    {
        EmailService.SendEmail(request);
        return Ok();
    }
}