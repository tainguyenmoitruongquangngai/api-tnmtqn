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
    public class PermissionController : ControllerBase
    {
        private readonly PermissionService _service;

        public PermissionController(PermissionService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<PermissionModel>> GetAllDashboarss()
        {
            return (await _service.GetAllPermissionAsync());
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<ActionResult<Permissions>> GetPermissionById(int Id)
        {
            var res = await _service.GetPermissionByIdAsync(Id);
            if (res == null)
            {
                return NotFound(new { message = "Permission not found" });
            }
            return Ok(new
            {
                user = res
            });
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<Permissions>> SavePermission(PermissionModel moddel)
        {
            var res = await _service.SavePermissionAsync(moddel);
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
        public async Task<ActionResult<Permissions>> DeletePermission(PermissionModel moddel)
        {
            var res = await _service.DeletePermissionAsync(moddel);
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
