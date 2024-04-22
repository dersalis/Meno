using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Meno.Api.Controllers
{
    [ApiController]
    [Route("categories")]
    public class CategoriesController : ControllerBaseApi
    {
        public CategoriesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }

        [HttpGet("getbyid/{id:guid}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update()
        {
            return Ok();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }
    }
}