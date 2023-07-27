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
    public class UserDashboardController : ControllerBase
    {
        private readonly UserDashboardService _service;

        public UserDashboardController(UserDashboardService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<UserDashboardModel>> GetAllUserDashboard()
        {
            return (await _service.GetAllUserDashboardAsync());
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<UserDashboardModel?> GetUserDashboardById(int Id)
        {
            return await _service.GetUserDashboardByIdAsync(Id);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<UserDashboards>> SaveUserDashboard(UserDashboardModel moddel)
        {
            var res = await _service.SaveUserDashboardAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "UserDashboard: Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "UserDashboard: Lỗi lưu dữ liệu" });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<UserDashboards>> DeleteUserDashboard(UserDashboardModel moddel)
        {
            var res = await _service.DeleteUserDashboardAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "UserDashboard: Dữ liệu đã được xóa" });
            }
            else
            {
                return Ok(new { message = "UserDashboard: Lỗi xóa dữ liệu" });
            }
        }
    }
}
