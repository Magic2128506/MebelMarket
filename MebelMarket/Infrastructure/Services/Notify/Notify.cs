using Microsoft.Extensions.Logging;
using MimeKit;
using System;

namespace MebelMarket.Infrastructure.Services.Notify
{
    public class Notify
    {
        private readonly ILogger<Notify> _logger;

        public Notify(ILogger<Notify> logger)
        {
            _logger = logger;
        }

        public void SendEmail(string to, string text)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Моя компания", "magicntr@gmail.com"));
                message.To.Add(new MailboxAddress(to));
                message.Subject = text;
                message.Body = new BodyBuilder() { HtmlBody = $"<div style=\"color: green;\">{text}</div>" }.ToMessageBody();

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate("magicntr@gmail.com", "Mehanik21");
                    client.Send(message);

                    client.Disconnect(true);
                }

            }
            catch (Exception exp)
            {
                _logger.LogError(exp.GetBaseException().Message);
            }
        }
    }
}
