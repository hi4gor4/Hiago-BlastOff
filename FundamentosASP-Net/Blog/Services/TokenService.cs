using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Blog.Models;
using Blog;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace Blog.Services;
public class TokenService
{
    public string GenerateToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(Configuration.JwtKey);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, value: "hiagorangel"),
                new Claim(ClaimTypes.Role, value: "admin" ),
                new Claim("Banana", value: "fruta")
            }),
            Expires = DateTime.UtcNow.AddHours(8),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature
            )
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}