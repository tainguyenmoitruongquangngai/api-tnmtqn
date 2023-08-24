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
    public class DashboardController : ControllerBase
    {
        private readonly DashboardService _service;

        public DashboardController(DashboardService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<DashboardModel>> GetAllDashboard()
        {
            return (await _service.GetAllDashboardAsync());
        }

        [HttpGet]
        [Route("listbyrole/{roleName}")]
        public async Task<List<RoleDashboardModel>> GetAllDashboardByRole(string roleName)
        {
            return await _service.GetDashboardByRoleAsync(roleName);
        }

        [HttpGet]
        [Route("listbyuser/{userName}")]
        public async Task<List<UserDashboardModel>> GetAllDashboardByUser(string userName)
        {
            return await _service.GetDashboardByUserAsync(userName);
        }


        [HttpGet]
        [Route("{Id}")]
        public async Task<DashboardModel?> GetDashboardById(int Id)
        {
            return await _service.GetDashboardByIdAsync(Id);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<Dashboards>> SaveDashboard(DashboardModel moddel)
        {
            var res = await _service.SaveDashboardAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Màn hình chức năng: Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Màn hình chức năng: Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<Dashboards>> DeleteDashboard(DashboardModel moddel)
        {
            var res = await _service.DeleteDashboardAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Màn hình chức năng: Dữ liệu đã được xóa" });
            }
            else
            {
                return BadRequest(new { message = "Màn hình chức năng: Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}
