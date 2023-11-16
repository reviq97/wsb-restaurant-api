using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_application.Common.Interfaces;
using wsb_restaurant_dal.Contracts;
using wsb_restaurant_domain.Models.Entities;

namespace wsb_restaurant_application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IJwtTokenGenerator jwtToken, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtToken;
            _userRepository = userRepository;
        }

        public AuthenticationResult Login(string email, string password)
        {
            var user = _userRepository.FindAsync(x => x.email == email);
            if (user is null)
            {
                throw new Exception("Invalid email or password");
            }

            return new AuthenticationResult(Guid.NewGuid(), "", "", "", "");
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            if (_userRepository.FindAsync(x => x.email == email).Result is not null)
            {
                throw new Exception("User already exsists");
            }
            var userId = Guid.NewGuid();

            var user = new User(userId, firstName, lastName, email, password);

            var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);
            return new AuthenticationResult(userId, firstName, lastName, email, token);
        }
    }
}
