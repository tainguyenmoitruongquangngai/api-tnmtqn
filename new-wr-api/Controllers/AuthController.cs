using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Models;
using new_wr_api.Models.Authenticate;
using new_wr_api.Service;
using System.Data;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _repo;

        public AuthController(IAuthService repo)
        {
            _repo = repo;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(UserModel modle)
        {
            var res = await _repo.RegisterAsync(modle);
            if (res == null)
            {
                return BadRequest(new
                {
                    message = "Register Failed. User is already exits",
                });
            }
            if (res.Succeeded == false)
            {
                return BadRequest(res);
            }
            return Ok(new
            {
                message = "User is registered",
                res = res
            });
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var res = await _repo.LoginAsync(model);
            if (string.IsNullOrEmpty(res))
            {
                return BadRequest(res);
            }
            return Ok(res);
        }

        [HttpPost]
        [Route("change-password/{userId}")]
        public async Task<ActionResult<AspNetUsers>> UpdatePassword(UserModel modle, string currentPassword, string newPassword)
        {
            var res = await _repo.UpdatePasswordAsync(modle, currentPassword, newPassword);
            if (res == null || res.Succeeded == false)
            {
                return BadRequest(new
                {
                    message = res
                });
            }
            return Ok(new
            {
                message = "Password is updated"
            });
        }

        [HttpPost]
        [Route("assign-role")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<AspNetUsers>> AssignRole(AssignRoleModel model)
        {
            if (model.userId == null || model.roleName == null)
            {
                return BadRequest(new
                {
                    message = "User or Role not found"
                });

            }

            var res = await _repo.AssignRoleAsync(model);

            if (res)
            {
                return Ok(new
                {
                    message = res
                });
            }
            return BadRequest(new
            {
                message = res
            });
        }

        [HttpPost]
        [Route("remove-role")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<AspNetUsers>> RemoveRole(AssignRoleModel model)
        {
            if (model.userId == null || model.roleName == null)
            {
                return BadRequest(new
                {
                    message = "User or Role not found"
                });

            }

            var res = await _repo.RemoveRoleAsync(model);

            if (res)
            {
                return Ok(new
                {
                    message = res
                });
            }
            return BadRequest(new
            {
                message = res
            });
        }

        [HttpPost]
        [Route("logout")]
        public async Task<IActionResult> Logout(HttpContext context)
        {
            var res = await _repo.LogoutAsync(context);
            if (res == false)
            {
                return BadRequest(false);
            }
            return Ok(true);
        }
    }

}
