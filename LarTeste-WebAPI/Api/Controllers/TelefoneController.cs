using LarTeste_WebAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LarTeste_WebAPI.Api.Controllers.BaseController;
using LarTeste_WebAPI.Domain.Models.Response;
using System.Net;
using LarTeste_WebAPI.Domain.Models.Input;
using LarTeste_WebAPI.Domain.Interfaces.Services;
using LarTeste_WebAPI.Services;

namespace LarTeste_WebAPI.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TelefoneController : ControllerAPI
{
    private readonly ITelefoneService _telefoneService;
    public TelefoneController(ITelefoneService telefoneService)
    {
        _telefoneService = telefoneService;
    }

    /// <summary>
    /// Adiciona um telefone ao banco de dados
    /// </summary>
    /// <param name="telefone">Objeto com os campos necessários para criação de um telefone</param>
    /// <returns>IActionResult</returns>
    /// <response code="201">Caso inserção seja feita com sucesso</response>
    [HttpPost]
     public async Task<IActionResult> RegistraNovoTelefone([FromBody] NovoTelefoneInputModel input)
        => Return(await _telefoneService.RegistraNovoTelefoneAsync(input));

    /*[HttpGet]
    [ProducesResponseType(typeof(ResultModel<TelefoneOutputModel>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetTelefonePorIdAsync([FromQuery] long id)
        => Return(await _telefoneService.GetTelefonePorIdAsync(id));

    [HttpGet("filter")]
    [ProducesResponseType(typeof(ResultModel<List<TelefoneOutputModel>>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetProductListByName([FromQuery] string name)
        => Return(await _telefoneService.GetTelefoneListByNameAsync(name));*/

    
}
