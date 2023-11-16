using wsb_restaurant_application.Common.Interfaces;
using wsb_restaurant_dal.Contracts;
using wsb_restaurant_domain.Models;
using wsb_restaurant_domain.Models.Entities;

namespace wsb_restaurant_application.Common.Services.Account
{
    public class AccountService : IAccountService
    {
        private readonly IJwtTokenGenerator jwtTokenGenerator;
        private readonly IUserRepository userRepository;

        public AccountService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            this.jwtTokenGenerator = jwtTokenGenerator;
            this.userRepository = userRepository;
        }

        public async Task<AuthenticationResult> Login(string email, string password)
        {
            var user = await userRepository.FindAsync(x => x.email == email);
            if (user is null)
            {
                throw new Exception("Invalid email or password");
            }

            var token = jwtTokenGenerator.GenerateToken(user.id, user.firstName, user.lastName);

            return new AuthenticationResult(token);
        }

        public async Task Register(string firstName, string lastName, string email, string password)
        {
            if (userRepository.FindAsync(x => x.email == email).Result is not null)
            {
                throw new Exception("User already exsists");
            }

            var userId = Guid.NewGuid();
            var user = new User(userId, firstName, lastName, email, password);
        }
    }
}
