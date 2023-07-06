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
        public async Task<ActionResult> Register(UserModel modle)
        {
            var res = await _repo.RegisterAsync(modle);
            if (res == true)
            {
                return Ok(new { message = "Đăng ký tài khoản thành công" });
            }
            else
            {
                return BadRequest(new { message = "Đăng ký tài khoản thất bại, tài khoản này đã tồn tại" });
            }

        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            var res = await _repo.LoginAsync(model);
            if (string.IsNullOrEmpty(res))
            {
                return BadRequest(new { message = "Thông tin tài khoản hoặc mật khẩu không chính xác" });
            }
            return Ok(res);
        }

        [HttpPost]
        [Route("change-password/{userId}")]
        //[Authorize(Roles = "Administrator")]
        public async Task<ActionResult<AspNetUsers>> UpdatePassword(UserModel modle, string currentPassword, string newPassword)
        {
            var res = await _repo.UpdatePasswordAsync(modle, currentPassword, newPassword);
            if (res == true)
            {
                return Ok(new { message = "Đổi mật khẩu thành công" });
            }
            else
            {
                return BadRequest(new { message = "Mật khẩu không chính xác" });
            }
        }

        [HttpPost]
        [Route("assign-role")]
        //[Authorize(Roles = "Administrator")]
        public async Task<ActionResult> AssignRole(AssignRoleModel model)
        {
            var res = await _repo.AssignRoleAsync(model);
            if (res == true)
            {
                return Ok(new { message = "AssignRole: Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "AssignRole: Lỗi lưu dữ liệu" });
            }

        }

        [HttpPost]
        [Route("remove-role")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> RemoveRole(AssignRoleModel model)
        {
            var res = await _repo.RemoveRoleAsync(model);

            if (res == true)
            {
                return Ok(new { message = "RemoveRole: Dữ liệu đã được xóa" });
            }
            else
            {
                return Ok(new { message = "RemoveRole: Lỗi xóa dữ liệu" });
            }
        }

        [HttpPost]
        [Route("logout")]
        public async Task<ActionResult> Logout(HttpContext context)
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
