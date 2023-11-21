using LarTeste_WebAPI.Api.Controllers.BaseController;
using LarTeste_WebAPI.Domain.Interfaces.Services;
using LarTeste_WebAPI.Domain.Models.Input;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LarTeste_WebAPI.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuarioController : ControllerAPI
{
    private readonly IUsuarioService _usuarioService;
    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }
    /// <summary>
    /// Adiciona um usuario ao banco de dados
    /// </summary>
    /// <param name="usuario">Objeto com os campos necessários para criação de um telefone</param>
    /// <returns>IActionResult</returns>
    /// <response code="201">Caso inserção seja feita com sucesso</response>
    [HttpPost]
    [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> RegistraNovoUsuario(NovoUsuarioInputModel input)
        => Return(await _usuarioService.RegistraNovoUsuarioAsync(input));
}
