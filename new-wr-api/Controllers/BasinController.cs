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
    public class BasinController : ControllerBase
    {
        private readonly BasinService _service;

        public BasinController(BasinService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<BasinModel>> GetAllBasin()
        {
            return (await _service.GetAllBasinAsync());
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<BasinModel?> GetBasinById(int Id)
        {
            return await _service.GetBasinByIdAsync(Id);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<Basins>> SaveBasin(BasinModel moddel)
        {
            var res = await _service.SaveBasinAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Lưu vực :Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Lưu vực :Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<Basins>> DeleteBasin(BasinModel moddel)
        {
            var res = await _service.DeleteBasinAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Lưu vực :Dữ liệu đã được xóa" });
            }
            else
            {
                return BadRequest(new { message = "Lưu vực :Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}
