using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ThongSoCongTrinhController : ControllerBase
    {
        private readonly CT_ThongSoService _service;

        public ThongSoCongTrinhController(CT_ThongSoService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("luu")]
        public async Task<ActionResult<CT_HangMuc>> Save(CT_ThongSoDto dto)
        {
            var res = await _service.SaveAsync(dto);
            if (res)
            {
                return Ok(new { message = "Thông số công trình: Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Thông số công trình: Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpPost]
        [Route("xoa/{Id}")]
        public async Task<ActionResult<CT_HangMuc>> Delete(int Id)
        {
            var res = await _service.DeleteAsync(Id);
            if (res == true)
            {
                return Ok(new { message = "Thông số công trình: Dữ liệu đã được xóa" });
            }
            else
            {
                return BadRequest(new { message = "Thông số công trình: Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}
