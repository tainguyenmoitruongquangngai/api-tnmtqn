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
    public class ConstructionDetailController : ControllerBase
    {
        private readonly ConstructionDetailService _service;

        public ConstructionDetailController(ConstructionDetailService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<ConstructionDetails>> SaveConstructionDetail(ConstructionDetailModel moddel)
        {
            var res = await _service.SaveConstructionDetailAsync(moddel);
            if (res)
            {
                return Ok(new { message = "Hạng mục công trình: Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Hạng mục công trình: Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<ConstructionDetails>> DeleteConstructionDetail(ConstructionDetailModel moddel)
        {
            var res = await _service.DeleteConstructionDetailAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Hạng mục công trình: Dữ liệu đã được xóa" });
            }
            else
            {
                return BadRequest(new { message = "Hạng mục công trình: Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}
