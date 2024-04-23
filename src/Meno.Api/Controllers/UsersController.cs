using MediatR;
using Meno.Application.Queries.Users.GetAllUsers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Meno.Api.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : ControllerBaseApi
    {
        public UsersController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("signup")]
        // [AllowAnonymous]
        public async Task<IActionResult> SignUp()
        {
            return Ok();
        }

        [HttpPost("signin")]
        // [AllowAnonymous]
        public async Task<IActionResult> SignIn()
        {
            return Ok();
        }

        [HttpPost("changepassword")]
        public async Task<IActionResult> ChangePassword()
        {
            return Ok();
        }

        [HttpGet]
        // [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var users = await _mediator.Send(new GetAllUsersQuery());
            return Ok(users);
        }

        [HttpGet("getbyid/{id:guid}")]
        // [AllowAnonymous]
        public async Task<IActionResult> GetById()
        {
            return Ok();
        }

        [HttpGet("getbyemail/{email}")]
        // [AllowAnonymous]
        public async Task<IActionResult> GetByEmail()
        {
            return Ok();
        }

        [HttpPut]
        // [AllowAnonymous]
        public async Task<IActionResult> Update()
        {
            return Ok();
        }

        [HttpDelete("{id:guid}")]
        // [AllowAnonymous]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }

        [HttpPost("forgotpassword")]
        // [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword()
        {
            return Ok();
        }

        [HttpPost("{userId:guid}/addplace")]
        // [AllowAnonymous]
        public async Task<IActionResult> AddPlace([FromRoute] Guid userId)
        {
            return Ok();
        }
        
        [HttpPut("{userId:guid}/updateplace/{placeId:guid}")]
        // [AllowAnonymous]
        public async Task<IActionResult> UpdatePlace([FromRoute] Guid userId, [FromRoute] Guid placeId)
        {
            return Ok();
        }

        [HttpPost("{userId:guid}/removeplace/{placeId:guid}")]
        // [AllowAnonymous]
        public async Task<IActionResult> RemovePlace([FromRoute] Guid userId, [FromRoute] Guid placeId)
        {
            return Ok();
        }

        [HttpGet("{userId:guid}/getallplaces")]
        // [AllowAnonymous]
        public async Task<IActionResult> GetAllPlaces()
        {
            return Ok();
        }

        [HttpGet("{userId:guid}/getplacebyid/{id:guid}")]
        // [AllowAnonymous]
        public async Task<IActionResult> GetPlaceById()
        {
            return Ok();
        }
    }
}