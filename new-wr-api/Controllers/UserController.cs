using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Data.Dto;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Administrator")]
    public class UserController : ControllerBase
    {
        private readonly UserService _repo;

        public UserController(UserService repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<UsersDto>> GetAllUsers()
        {
            return await _repo.GetAllUsersAsync();
        }

        [HttpGet]
        [Route("{userId}")]
        public async Task<ActionResult<ApplicationUser>> GetUserById(string userId)
        {
            var res = await _repo.GetUserByIdAsync(userId);
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
        public async Task<ActionResult<ApplicationUser>> SaveUser(UsersDto dto)
        {
            var res = await _repo.SaveUserAsync(dto);
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
        public async Task<ActionResult<ApplicationUser>> DeleteUser(UsersDto dto)
        {
            var res = await _repo.DeleteUserAsync(dto);
            if (res == false)
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
