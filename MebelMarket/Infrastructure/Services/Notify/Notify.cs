using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

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
                message.From.Add(new MailboxAddress("МебельМаркет бот", "eiam44718@gmail.com"));
                message.To.Add(new MailboxAddress(to));
                message.Subject = "Новый заказ на сайте!";
                message.Body = new BodyBuilder() { HtmlBody = $"<div style=\"color: green;\">{text}</div>" }.ToMessageBody();

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate("eiam44718@gmail.com", "Mehanik21");
                    client.Send(message);

                    client.Disconnect(true);
                }
            }
            catch (Exception exp)
            {
                _logger.LogError(exp.GetBaseException().Message);
            }
        }

        public async Task SendMessageToTelegramAsync(string text)
        {
            var botClient = new TelegramBotClient("1298591915:AAFzQrlYrX4IHCeB--5O0gReUyfN6IwCGAs");
            await botClient.SendTextMessageAsync("-527286678", text);
        }
    }
}
