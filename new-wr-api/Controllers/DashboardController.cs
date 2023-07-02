using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Data.Dto;
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
        public async Task<List<DashboardDto>> GetAllDashboarss()
        {
            return await _service.GetAllDashboardAsync();
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<ActionResult<ApplicationUser>> GetUserById(int Id)
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
    }
}
