using BooksLibrary.Data.Models.Entities;
using BooksLibrary.Data.Models.Requests;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Security.Claims;

namespace BookLibrary.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly IUserEmailStore<IdentityUser> _emailStore;

        public AuthController(
            UserManager<IdentityUser> userManager,
            IUserStore<IdentityUser> userStore)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = (IUserEmailStore<IdentityUser>)_userStore;
        }

        [HttpPost]
        [Route("[controller]/register")]
        public async Task<IActionResult> Register([FromBody]RegisterRequest request)
        {
            var user = new IdentityUser();

            await _userStore.SetUserNameAsync(user, request.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(user, request.Email, CancellationToken.None);
            var result = await _userManager.CreateAsync(user, request.Password);

            if(result.Succeeded)
            {
                return Ok();
            }

            if(result.Errors.Any()) {
                return BadRequest(result
                    .Errors
                    .Select(e => e.Description)
                    .Aggregate((a, b) => a + "\n" + b)
                    );
            }

            return BadRequest();
        } 
    }
}
