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
            return await _service.GetAllDashboardAsync();
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<ActionResult<Dashboards>> GetDashboardById(int Id)
        {
            var res = await _service.GetDashboardByIdAsync(Id);
            if (res == null)
            {
                return NotFound(new { message = "Dashboard not found" });
            }
            return Ok(new
            {
                user = res
            });
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<Dashboards>> SaveDashboard(DashboardModel model)
        {
            var res = await _service.SaveDashboardAsync(model);
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
        public async Task<ActionResult<Dashboards>> DeleteDashboard(DashboardModel model)
        {
            var res = await _service.DeleteDashboardAsync(model);
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
    }
}
