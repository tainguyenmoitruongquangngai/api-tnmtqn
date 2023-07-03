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
        private readonly RoleService _repo;

        public RoleController(RoleService repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<ApplicationRole>> GetAllRoles()
        {
            return await _repo.GetAllRolesAsync();
        }

        [HttpGet]
        [Route("{roleId}")]
        public async Task<ApplicationRole?> GetRoleById(string roleId)
        {
            return await _repo.GetRoleByIdAsync(roleId);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<ApplicationRole>> SaveRole(RoleModel model)
        {
            var res = await _repo.SaveRoleAsync(model);
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
        public async Task<ActionResult<ApplicationRole>> DeleteRole(string roleId)
        {
            var res = await _repo.DeleteRoleAsync(roleId);
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
