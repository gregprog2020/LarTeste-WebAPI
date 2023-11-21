using LarTeste_WebAPI.Api.Controllers.BaseController;
using LarTeste_WebAPI.Infra.Context;
using LarTeste_WebAPI.Domain.Interfaces.Services;
using LarTeste_WebAPI.Domain.Models.Input;
using LarTeste_WebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using LarTeste_WebAPI.Domain.Models.Response;
using System.Net;
using LarTeste_WebAPI.Domain.Models.Output;

namespace LarTeste_WebAPI.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PessoaController : ControllerAPI
{
    private readonly IPessoaService _pessoaService;
    public PessoaController(IPessoaService pessoaService)
    {
        _pessoaService = pessoaService;
    }

    /// <summary>
    /// Adiciona uma pessoa ao banco de dados
    /// </summary>
    /// <param name="pessoa">Objeto com os campos necessários para criação de uma pessoa</param>
    /// <returns>IActionResult</returns>
    /// <response code="201">Caso inserção seja feita com sucesso</response>
    [HttpPost]
    public async Task<IActionResult> RegistraNovaPessoa([FromBody] NovaPessoaInputModel input)
        => Return(await _pessoaService.RegistraNovaPessoaAsync(input));

    [HttpGet]
    [ProducesResponseType(typeof(ResultModel<PessoaOutputModel>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetPessoaPorIdAsync([FromQuery] int id)
            => Return(await _pessoaService.GetPessoaPorIdAsync(id));


    [HttpGet("filter")]
    [ProducesResponseType(typeof(ResultModel<List<PessoaOutputModel>>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetPessoaPorNomeAsync([FromQuery] string nome)
            => Return(await _pessoaService.GetPessoaPorNomeAsync(nome));


}

