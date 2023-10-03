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
    public class ConstructionTypesController : ControllerBase
    {
        private readonly ConstructionTypesService _service;

        public ConstructionTypesController(ConstructionTypesService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<ConstructionTypesModel>> GetAllConstructionTypes()
        {
            return (await _service.GetAllConstructionTypesAsync());
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<ConstructionTypesModel?> GetConstructionTypesById(int Id)
        {
            return await _service.GetConstructionTypesByIdAsync(Id);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<ConstructionTypes>> SaveConstructionTypes(ConstructionTypesModel moddel)
        {
            var res = await _service.SaveConstructionTypesAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Loại công trình: Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Loại công trình: Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpPost]
        [Route("delete/{Id}")]
        public async Task<ActionResult<ConstructionTypes>> DeleteConstructionTypes(int Id)
        {
            var res = await _service.DeleteConstructionTypesAsync(Id);
            if (res == true)
            {
                return Ok(new { message = "Loại công trình: Dữ liệu đã được xóa" });
            }
            else
            {
                return BadRequest(new { message = "Loại công trình: Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}
