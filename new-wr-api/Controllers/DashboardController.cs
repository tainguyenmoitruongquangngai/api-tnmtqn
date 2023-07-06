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
                return Ok(new { message = "Dashboard: Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Dashboard: Lỗi lưu dữ liệu" });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<Dashboards>> DeleteDashboard(DashboardModel moddel)
        {
            var res = await _service.DeleteDashboardAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Dashboard: Dữ liệu đã được xóa" });
            }
            else
            {
                return Ok(new { message = "Dashboard: Lỗi xóa dữ liệu" });
            }
        }
    }
}
