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
    public class PermissionController : ControllerBase
    {
        private readonly PermissionService _service;

        public PermissionController(PermissionService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<PermissionModel>> GetAllPermission()
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
        public async Task<ActionResult<Permissions>> SavePermission(PermissionModel moddel)
        {
            var res = await _service.SavePermissionAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Quyền hạn: Đã được thêm" });
            }
            else
            {
                return BadRequest(new { message = "Quyền hạn: Lỗi" });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<Permissions>> DeletePermission(PermissionModel moddel)
        {
            var res = await _service.DeletePermissionAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Quyền hạn: Dữ liệu đã được xóa" });
            }
            else
            {
                return Ok(new { message = "Quyền hạn: Lỗi xóa dữ liệu" });
            }
        }
    }
}
