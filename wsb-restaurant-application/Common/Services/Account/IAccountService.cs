using wsb_restaurant_application.Services.Authentication;

namespace wsb_restaurant_application.Common.Services.Account
{
    public interface IAccountService
    {
        Task<AuthenticationResult> Login(string email, string password);
        Task<AuthenticationResult> Register(string firstName, string lastName, string email, string password);
    }
}
