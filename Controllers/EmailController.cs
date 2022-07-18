using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace SimpleEmailApp.Controllers;

[Route("api/{controller}")]
[ApiController]
public class EmailController : ControllerBase
{
    [HttpPost]
    public IActionResult SendEmail(string body)
    {
        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse("candace82@ethereal.email"));
        email.To.Add(MailboxAddress.Parse("candace82@ethereal.email"));
        email.Subject = "Test Email Subject";
        email.Body = new TextPart(TextFormat.Html)
        {
            Text = body
        };

        using var smtp = new SmtpClient();
        smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
    }
}