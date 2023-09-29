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
    public class ConstructionController : ControllerBase
    {
        private readonly ConstructionService _service;

        public ConstructionController(ConstructionService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<ConstructionModel>> GetAllConstruction(string? ConstructionName, string? ExploitedWS, int ConstructionTypeId, int BusinessId, int DistrictId, int CommuneId, int PageIndex, int PageSize)
        {
            return (await _service.GetAllConstructionAsync(ConstructionName, ExploitedWS, ConstructionTypeId, BusinessId, DistrictId, CommuneId, PageIndex, PageSize));
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<ConstructionModel?> GetConstructionById(int Id)
        {
            return await _service.GetConstructionByIdAsync(Id);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<Constructions>> SaveConstruction(ConstructionModel moddel)
        {
            var res = await _service.SaveConstructionAsync(moddel);
            if (res > 0)
            {
                return Ok(new { message = "Công trình: Dữ liệu đã được lưu", id = res });
            }
            else
            {
                return BadRequest(new { message = "Công trình: Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpPost]
        [Route("delete/{Id}")]
        public async Task<ActionResult<Constructions>> DeleteConstruction(int Id)
        {
            var res = await _service.DeleteConstructionAsync(Id);
            if (res == true)
            {
                return Ok(new { message = "Công trình: Dữ liệu đã được xóa" });
            }
            else
            {
                return BadRequest(new { message = "Công trình: Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}
