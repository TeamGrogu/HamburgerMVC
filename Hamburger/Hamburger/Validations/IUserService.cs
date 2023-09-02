namespace Hamburger.Validations
{
	public interface IUserService
	{
		bool IsEmailInUse(string email);
	}
}
