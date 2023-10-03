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
    public class SubBasinController : ControllerBase
    {
        private readonly SubBasinService _service;

        public SubBasinController(SubBasinService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<SubBasinModel>> GetAllSubBasin()
        {
            return (await _service.GetAllSubBasinAsync());
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<SubBasinModel?> GetSubBasinById(int Id)
        {
            return await _service.GetSubBasinByIdAsync(Id);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<SubBasins>> SaveSubBasin(SubBasinModel moddel)
        {
            var res = await _service.SaveSubBasinAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Tiểu vùng quy hoạch :Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Tiểu vùng quy hoạch :Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<SubBasins>> DeleteSubBasin(int Id)
        {
            var res = await _service.DeleteSubBasinAsync(Id);
            if (res == true)
            {
                return Ok(new { message = "Tiểu vùng quy hoạch :Dữ liệu đã được xóa" });
            }
            else
            {
                return BadRequest(new { message = "Tiểu vùng quy hoạch :Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}
