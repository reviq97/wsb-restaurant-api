using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using wsb_restaurant_application.Common.Interfaces.Authentication;

namespace wsb_restaurant_infrastructure.Authentication
{
    internal class JwtTokenGenerator : IJwtTokenGenerator
    {
        public string GenerateToken(Guid userId, string firstName, string lastName)
        {
            var signCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SECURITY_TOKEN_1")),
                SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
                new Claim(JwtRegisteredClaimNames.GivenName, firstName),
                new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var securityToken = new JwtSecurityToken(
                issuer: "restaurant-api",
                expires: DateTime.Now.AddDays(1),
                claims: claims,
                signingCredentials: signCredentials);

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
    }
}
