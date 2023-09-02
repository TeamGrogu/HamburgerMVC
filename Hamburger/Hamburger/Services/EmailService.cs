using Hamburger.Models;
using MimeKit;
using MailKit.Net.Smtp;

namespace Hamburger.Services
{
	public class EmailService : IEmailService
	{
		private readonly EmailConfiguration _emailConfig;
		public EmailService(EmailConfiguration emailConfig)
		{
			_emailConfig = emailConfig;
		}

		public void SendEmail(Message message)
		{
			var emailMessage = CreateEmailMessage(message);
			Send(emailMessage);
		}

		private void Send(object emailMessage)
		{
			using var client = new SmtpClient();
			try
			{
				client.Connect(_emailConfig.SmtpServer, _emailConfig.Port, true);
				client.AuthenticationMechanisms.Remove("XOAUTH2");
				client.Authenticate(_emailConfig.UserName, _emailConfig.Password);
				client.Send((MimeMessage)emailMessage);
			}
			catch (Exception)
			{
				//log an error message or throw an exception or both
				throw;
			}
			finally
			{
				client.Disconnect(true);
				client.Dispose();
			}
		}

		private object CreateEmailMessage(Message message)
		{
			var emailMessage = new MimeMessage();
			emailMessage.From.Add(new MailboxAddress("Overthinking Burger", _emailConfig.From));
			emailMessage.To.AddRange(message.To);
			emailMessage.Subject = message.Subject;
			emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = message.Content };
			return emailMessage;
		}
	}
}
