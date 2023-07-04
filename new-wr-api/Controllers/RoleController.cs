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
    public class RoleController : ControllerBase
    {
        private readonly RoleService _service;

        public RoleController(RoleService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<AspNetRoles>> GetAllRoles()
        {
            return await _service.GetAllRolesAsync();
        }

        [HttpGet]
        [Route("{roleId}")]
        public async Task<AspNetRoles?> GetRoleById(string roleId)
        {
            return await _service.GetRoleByIdAsync(roleId);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<AspNetRoles>> SaveRole(RoleModel model)
        {
            var res = await _service.SaveRoleAsync(model);
            if (res.Succeeded)
            {
                return Ok(new
                {
                    message = res,
                });
            }
            return BadRequest(new
            {
                message = res
            });
        }

        [HttpPost]
        [Route("detete/{roleId}")]
        public async Task<ActionResult<AspNetRoles>> DeleteRole(string roleId)
        {
            var res = await _service.DeleteRoleAsync(roleId);
            if (!res.Succeeded)
            {
                return BadRequest(new
                {
                    message = res
                });
            }
            return Ok(new
            {
                message = "Role is deleted."
            });
        }
    }
}
