using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Models;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrator")]
    public class RoleDashboardController : ControllerBase
    {
        private readonly RoleDashboardService _service;

        public RoleDashboardController(RoleDashboardService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<RoleDashboardModel>> GetAllRoleDashboard()
        {
            return (await _service.GetAllRoleDashboardAsync());
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<RoleDashboardModel?> GetRoleDashboardById(int Id)
        {
            return await _service.GetRoleDashboardByIdAsync(Id);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<RoleDashboards>> SaveRoleDashboard(RoleDashboardModel moddel)
        {
            var res = await _service.SaveRoleDashboardAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "RoleDashboard: Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "RoleDashboard: Lỗi lưu dữ liệu" });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<RoleDashboards>> DeleteRoleDashboard(RoleDashboardModel moddel)
        {
            var res = await _service.DeleteRoleDashboardAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "RoleDashboard: Dữ liệu đã được xóa" });
            }
            else
            {
                return Ok(new { message = "RoleDashboard: Lỗi xóa dữ liệu" });
            }
        }
    }
}
