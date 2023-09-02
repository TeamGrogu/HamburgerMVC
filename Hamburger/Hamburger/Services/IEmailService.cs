using Hamburger.Models;

namespace Hamburger.Services
{
	public interface IEmailService
	{
		void SendEmail(Message message);
	}
}
