namespace Hamburger.Services
{
    public interface IUserService
    {
        bool IsEmailInUse(string email);
    }
}
