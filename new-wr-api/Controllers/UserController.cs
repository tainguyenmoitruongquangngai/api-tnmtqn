using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Data.Dto;
using new_wr_api.Models;
using new_wr_api.Repositories;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Administrator")]
    public class UserController : ControllerBase
    {
        private readonly UserRepositories _repo;

        public UserController(UserRepositories repo)
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
        [Route("create")]
        public async Task<ActionResult<ApplicationUser>> CreateUser(UsersDto dto)
        {
            var res = await _repo.CreateUserAsync(dto);
            if (res.Succeeded)
            {
                return Ok(new
                {
                    message = "User is created",
                    res = res
                });
            }
            return BadRequest(new
            {
                message = res
            });
        }

        [HttpPost]
        [Route("update/{userName}")]
        public async Task<ActionResult<ApplicationUser>> UpdateUser(string userName, UsersDto dto)
        {
            var res = await _repo.UpdateUserAsync(userName, dto);
            if (res == null || res.Succeeded == false)
            {
                return BadRequest(new
                {
                    message = res
                });
            }
            return Ok(new
            {
                message = "User is updated",
                res = res
            });

        }

        [HttpPost]
        [Route("delete/{userId}")]
        public async Task<ActionResult<ApplicationUser>> DeleteUser(string userId)
        {
            var res = await _repo.DeleteUserAsync(userId);
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
