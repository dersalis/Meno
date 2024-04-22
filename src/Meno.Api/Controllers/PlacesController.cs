using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Meno.Api.Controllers
{
    [ApiController]
    [Route("places")]
    public class PlacesController : ControllerBaseApi
    {
        public PlacesController(IMediator mediator) : base(mediator)
        {
        }
        
        [HttpPost("{placeId:guid}/addmenu")]
        [AllowAnonymous]
        public async Task<IActionResult> AddMenu()
        {
            return Ok();
        }

        [HttpPut("{placeId:guid}/updatemenu/{menuid:guid}")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateMenu([FromRoute] Guid menuid)
        {
            return Ok();
        }
        
        [HttpDelete("{placeId:guid}/deletemenu/{menuid:guid}")]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteMenu([FromRoute] Guid menuid)
        {
            return Ok();
        }

        [HttpGet("{placeId:guid}/getallmenus")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllMenus()
        {
            return Ok();
        }

        [HttpGet("{placeId:guid}/getmenubyid/{id:guid}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetMenuById()
        {
            return Ok();
        }

        [HttpPost("{placeId:guid}/duplicatemenu/{menuid:guid}")]
        [AllowAnonymous]
        public async Task<IActionResult> DuplicateMenu([FromRoute] Guid menuid)
        {
            return Ok();
        }
    }
}