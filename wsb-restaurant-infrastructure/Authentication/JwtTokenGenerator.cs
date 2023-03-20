using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using wsb_restaurant_application.Common.Interfaces;

namespace wsb_restaurant_infrastructure.Authentication
{
    internal class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly IOptions<JwtAppSettings> _jwtSettings;

        public JwtTokenGenerator(IOptions<JwtAppSettings> jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public string GenerateToken(Guid userId, string firstName, string lastName)
        {
            var signCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Value.Secret)),
                SecurityAlgorithms.HmacSha256);


            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
                new Claim(JwtRegisteredClaimNames.GivenName, firstName),
                new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var securityToken = new JwtSecurityToken(
                audience: _jwtSettings.Value.Audience,
                issuer: _jwtSettings.Value.Issuer,
                expires: DateTime.Now.AddDays(_jwtSettings.Value.ExpirationMin),
                claims: claims,
                signingCredentials: signCredentials);

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
    }
}
