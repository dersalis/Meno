using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Meno.Api.Controllers
{
    [ApiController]
    [Route("menus")]
    public class MenusController : ControllerBaseApi
    {
        public MenusController(IMediator mediator) : base(mediator)
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
        [AllowAnonymous]
        public async Task<IActionResult> Create()
        {
            return Ok();
        }

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> Update()
        {
            return Ok();
        }

        [HttpDelete("{id:guid}")]
        [AllowAnonymous]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }

        [HttpPost("addmenuitem")]
        [AllowAnonymous]
        public async Task<IActionResult> AddMenuItem()
        {
            return Ok();
        }

        [HttpPut("{menuid:guid}/updatemenuitem/{menuitemid:guid}")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateMenuItem()
        {
            return Ok();
        }

        [HttpDelete("{menuid:guid}/removemenuitem/{menuitemid:guid}")]
        [AllowAnonymous]
        public async Task<IActionResult> RemoveMenuItem()
        {
            return Ok();
        }

        [HttpGet("{menuid:guid}/getmenuitems")]
        [AllowAnonymous]
        public async Task<IActionResult> GetMenuItems()
        {
            return Ok();
        }
    }
}