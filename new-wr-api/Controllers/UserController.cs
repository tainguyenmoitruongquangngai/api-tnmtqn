using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Models;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Administrator")]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<UserModel>> GetAllUsers()
        {
            return await _service.GetAllUsersAsync();
        }

        [HttpGet]
        [Route("{userId}")]
        public async Task<ActionResult<ApplicationUser>> GetUserById(string userId)
        {
            var res = await _service.GetUserByIdAsync(userId);
            if (res == null)
            {
                return NotFound(new { message = "User not found" });
            }
            return Ok(new
            {
                user = res
            });
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<ApplicationUser>> SaveUser(UserModel model)
        {
            var res = await _service.SaveUserAsync(model);
            if (res.Succeeded)
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
        [Route("delete")]
        public async Task<ActionResult<ApplicationUser>> DeleteUser(UserModel model)
        {
            var res = await _service.DeleteUserAsync(model);
            if (!res.Succeeded)
            {
                return BadRequest(new
                {
                    message = res
                });
            }
            return Ok(new
            {
                message = "User is deleted."
            });
        }

    }
}
