using LarTeste_WebAPI.Domain.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace LarTeste_WebAPI.Api.Controllers.BaseController
{
    public class ControllerAPI : ControllerBase
    {
        public IActionResult Return<T>(ResultModel<T> result)
            => result.Success ? Ok(result) : BadRequest(result);
    }
}
