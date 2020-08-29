using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Template.Application.Interfaces;
using Template.Application.ViewModels;
using Template.Auth.Services;

namespace Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class UsersController : ControllerBase
    {

        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet, AllowAnonymous]
        public IActionResult Get()
        {
            return Ok(this.userService.Get());
        }

        [HttpPost, AllowAnonymous]
        public IActionResult Post(UserViewModel userViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(this.userService.Post(userViewModel));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            return Ok(this.userService.GetById(id));
        }

        [HttpPut, AllowAnonymous]
        public IActionResult Put(UserViewModel userViewModel)
        {
            return Ok(this.userService.Put(userViewModel));
        }

        [HttpDelete("{userId}"), AllowAnonymous]
        public IActionResult Delete(string userId)
        {
            //string _userId = TokenService.GetValueFromClaim(HttpContext.User.Identity, ClaimTypes.NameIdentifier);

            return Ok(this.userService.Delete(userId));
        }

        [HttpPost("authenticate"), AllowAnonymous]
        public IActionResult Authenticate(UserAuthenticateRequestViewModel userViewModel)
        {
            return Ok(this.userService.Authenticate(userViewModel));
        }
    }
}
