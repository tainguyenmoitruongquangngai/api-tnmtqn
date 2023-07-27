using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Models;
using new_wr_api.Models.Authenticate;
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
        public async Task<UserModel> GetUserById(string userId)
        {
            return await _service.GetUserByIdAsync(userId);
        }

        [HttpGet]
        [Route("getuserinfo/{userId}")]
        public async Task<UserInfoModel> GetUserInfoByIdAsync(string userId)
        {
            return await _service.GetUserInfoByIdAsync(userId);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult> SaveUser(UserModel model)
        {
            var res = await _service.SaveUserAsync(model);
            if (res == true)
            {
                return Ok(new { message = "User: Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "User: Lỗi lưu dữ liệu" });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult> DeleteUser(UserModel model)
        {
            var res = await _service.DeleteUserAsync(model);
            if (res == true)
            {
                return Ok(new { message = "User: Dữ liệu đã được xóa" });
            }
            else
            {
                return Ok(new { message = "User: Lỗi xóa dữ liệu" });
            }
        }
    }
}