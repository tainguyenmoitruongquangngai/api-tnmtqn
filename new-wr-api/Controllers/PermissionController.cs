using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Models;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Administrator")]
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
        public async Task<PermissionModel?> GetPermissionById(int Id)
        {
            return await _service.GetPermissionByIdAsync(Id);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult> SavePermission(PermissionModel moddel)
        {
            var res = await _service.SavePermissionAsync(moddel);
            return Ok(new
            {
                message = res
            });
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult> DeletePermission(PermissionModel moddel)
        {
            var res = await _service.DeletePermissionAsync(moddel);
            return Ok(new
            {
                message = res
            });
        }
    }
}
