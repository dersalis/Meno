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

        [HttpPost("{menuId:guid}/addmenuitem")]
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