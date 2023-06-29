using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Models;
using new_wr_api.Repositories;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admintrator")]
    public class RoleController : ControllerBase
    {
        private readonly RoleRepositories _repo;

        public RoleController(RoleRepositories repo)
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
        [Route("create")]
        public async Task<ActionResult<ApplicationRole>> CreateRole(RoleViewModel model)
        {
            var res = await _repo.CreateRoleAsync(model.Name, model.isDefault);
            if (res.Succeeded)
            {
                return Ok(new
                {
                    message = "Role is created",
                    res = res
                });
            }
            return BadRequest(new
            {
                message = res
            });
        }

        [HttpPost]
        [Route("update/{roleId}")]
        public async Task<ActionResult<ApplicationRole>> UpdateRole(string roleId, RoleViewModel model)
        {
            var res = await _repo.UpdateRoleAsync(roleId, model);
            if (res != null)
            {
                return Ok(new
                {
                    message = "Role is created",
                    res = res
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
            if (res == false)
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
