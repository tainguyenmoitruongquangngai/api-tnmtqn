using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Models;
using new_wr_api.Service;

namespace new_wr_api.Controllers.CongTrinh
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HangMucCongTrinhController : ControllerBase
    {
        private readonly CT_HangMucService _service;

        public HangMucCongTrinhController(CT_HangMucService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("luu")]
        public async Task<ActionResult<CT_HangMuc>> SaveDetail(CT_HangMucDto dto)
        {
            var res = await _service.SaveDetailAsync(dto);
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
        [Route("xoa/{Id}")]
        public async Task<ActionResult<CT_HangMuc>> DeleteDetail(int Id)
        {
            var res = await _service.DeleteDetailAsync(Id);
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
