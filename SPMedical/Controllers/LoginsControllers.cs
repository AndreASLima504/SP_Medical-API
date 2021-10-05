using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SPMedical.Domains;
using SPMedical.Interfaces;
using SPMedical.Repositories;
using SPMedical.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SPMedical.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsControllers : ControllerBase
    {
        public LoginsControllers()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        private IUsuarioRepository _usuarioRepository { get; set; }
        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                
                Usuario usuarioBuscado = _usuarioRepository.Login(login.Email, login.Senha);
                if (usuarioBuscado == null)
                {
                return BadRequest("Email ou senha incorretos");
                }
                    var minhasClaims = new[]
                    {
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.UsuarioId.ToString()),
                    new Claim(ClaimTypes.Role, usuarioBuscado.TipoUsuarioId.ToString())
                    };

                    var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("sp-med-chave-login"));

                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var newToken = new JwtSecurityToken(
                            issuer: "SPMed.webAPI",
                            audience: "SPMed.webAPI",
                            claims: minhasClaims,
                            expires: DateTime.Now.AddMinutes(30),
                            signingCredentials: creds
                        );
                    return Ok(new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(newToken)
                    });
             }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}

    

