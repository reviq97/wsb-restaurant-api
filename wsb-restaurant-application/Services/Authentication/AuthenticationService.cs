using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsb_restaurant_application.Common.Interfaces;

namespace wsb_restaurant_application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtToken)
        {
            _jwtTokenGenerator = jwtToken;
        }

        public AuthenticationResult Login(string email, string password)
        {

            return new AuthenticationResult(Guid.NewGuid(), "aa", "sa", email, "token");
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            //if user exists

            //create user(uniqe id)

            //create jwt token
            var userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);
            return new AuthenticationResult(userId, firstName, lastName, email, token);
        }
    }
}
