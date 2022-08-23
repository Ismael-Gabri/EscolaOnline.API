using EscolaOnline.Api.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EscolaOnline.Api.Services
{
    public class TokenService
    {
        public string GenerateToken(Student user)
        {
            //Criar instancia do tokenHandler, ultilizado pra gerar o token
            var tokenHandler = new JwtSecurityTokenHandler();

            //Criamos uma variavel para a chave do token
            var jwtKey = Encoding.ASCII.GetBytes(Configuration.JwtKey);

            //Criamos a especificacao do token, lugar onde vc decide as informacoes do token
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddHours(8), //Aqui definimos o tempo de expiracao do token
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(jwtKey), SecurityAlgorithms.HmacSha256Signature), //Definimos o sistema de incript do nosso token
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, "Harry"),
                    new Claim(ClaimTypes.Role, "student"),
                    new Claim("fruta", "banana")
                })
            };

            //Criamos o token baseado nas informacoes que informamos previamente
            var token = tokenHandler.CreateToken(tokenDescriptor);

            //retornamos o token com o tokenHandler usando o WriteToken para pegarmos ele em formato string
            return tokenHandler.WriteToken(token);
        }
    }
}
