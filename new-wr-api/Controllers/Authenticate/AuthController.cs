﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Models;
using System.Security.Claims;
using new_wr_api.Models.Authenticate;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("[controller]")]
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
        public async Task<ActionResult> Register(UserModel model)
        {
            var res = await _repo.RegisterAsync(model);
            if (res == true)
            {
                return Ok(new { message = "Đăng ký tài khoản thành công" });
            }
            else
            {
                return BadRequest(new { message = "Đăng ký tài khoản thất bại, tài khoản này đã tồn tại", error = true });
            }

        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            var res = await _repo.LoginAsync(model);
            if (string.IsNullOrEmpty(res))
            {
                return BadRequest(new { message = "Thông tin tài khoản hoặc mật khẩu không chính xác", error = true });
            }
            return Ok(res);
        }

        [HttpPost]
        [Route("change-password")]
        public async Task<ActionResult<AspNetUsers>> UpdatePassword(ChangePasswordModel model)
        {
            var res = await _repo.UpdatePasswordAsync(model);
            if (res == true)
            {
                return Ok(new { message = "Đổi mật khẩu thành công" });
            }
            else
            {
                //return BadRequest(new { message = "Đổi mật khẩu thất bại", error = true });
                return BadRequest(new { message = "Đổi mật khẩu thất bại", error = true, data = new { model } });
            }
        }

        [HttpPost]
        [Route("set-password")]
        public async Task<ActionResult<AspNetUsers>> SetPassword(SetPasswordModel model)
        {
            var res = await _repo.SetPasswordAsync(model);
            if (res == true)
            {
                return Ok(new { message = "Đặt mật khẩu thành công" });
            }
            else
            {
                return BadRequest(new { message = "Đặt mật khẩu thất bại", error = true });
            }
        }

        [HttpPost]
        [Route("assign-role")]
        public async Task<ActionResult> AssignRole(AssignRoleModel model)
        {
            var res = await _repo.AssignRoleAsync(model);
            if (res == true)
            {
                return Ok(new { message = "Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Lỗi lưu dữ liệu", error = true });
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
                return Ok(new { message = "Dữ liệu đã được xóa" });
            }
            else
            {
                return Ok(new { message = "Lỗi xóa dữ liệu", error = true });
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
