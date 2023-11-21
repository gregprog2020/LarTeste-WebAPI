using LarTeste_WebAPI.Models;
using LarTeste_WebAPI.Infra.Repositories;
using LarTeste_WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LarTeste_WebAPI.Api.Controllers
{
    /*[Route("v1/account")]
    public class AutenticacaoController : Controller
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Autenticacao([FromBody] Usuario model)
        {
            var user = UserRepository.Get(model.Nome, model.Senha);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var tkn = Token.Generate(user);
            user.Senha = "";
            return new
            {
                user,
                token = tkn,
            };
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => string.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("usuario")]
        [Authorize(Roles = "usuario,admin")]
        public string Employee() => "Usuario";

        [HttpGet]
        [Route("admin")]
        [Authorize(Roles = "admin")]
        public string Manager() => "Administrador";

    }*/
}
