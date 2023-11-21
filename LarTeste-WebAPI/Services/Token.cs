using LarTeste_WebAPI.Infra.Configuration;
using LarTeste_WebAPI.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LarTeste_WebAPI.Services
{
    public class Token
    {
        public static object Generate(Usuario usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.PrivateKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuario.Nome.ToString()),
                    new Claim(ClaimTypes.Role, usuario.Roles.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(8),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        /*var handler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(Settings.PrivateKey);
        var credentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = GenerateClaims(usuario),
            SigningCredentials = credentials,
            Expires = DateTime.UtcNow.AddHours(1),
        };
        var token = handler.CreateToken(tokenDescriptor);
        return handler.WriteToken(token);
    }


    private static ClaimsIdentity GenerateClaims(Usuario usuario)
    {
        var claims = new ClaimsIdentity();
        claims.AddClaim(new Claim(ClaimTypes.Name, usuario.Nome));
        foreach (var role in usuario.Roles)
            claims.AddClaim(new Claim(ClaimTypes.Role, usuario.roles));

        return claims;*/
    }
    
}
