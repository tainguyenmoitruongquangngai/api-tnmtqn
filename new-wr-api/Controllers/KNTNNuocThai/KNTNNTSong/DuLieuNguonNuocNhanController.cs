using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DuLieuNguonNuocNhanController : ControllerBase
    {
        private readonly DuLieuNguonNuocNhanService _service;

        public DuLieuNguonNuocNhanController(DuLieuNguonNuocNhanService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("danhsach")]
        public async Task<List<DuLieuNguonNuocNhanDto>> GetAll()
        {
            return await _service.GetAllDulieuNguonNuocNhanAsync();
        }

        [HttpPost]
        [Route("luu")]
        public async Task<ActionResult<DuLieuNguonNuocNhan>> Save(DuLieuNguonNuocNhanDto dto)
        {
            var res = await _service.SaveDulieuNguonNuocNhanAsync(dto);
            if (res == true)
            {
                return Ok(new { message = "Biểu mẫu: Dữ liệu đã được lưu", id = res });
            }
            else
            {
                return BadRequest(new { message = "Biểu mẫu: Lỗi lưu dữ liệu", error = true });
            }
        }


        [HttpGet]
        [Route("xoa/{Id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var res = await _service.DeleteDulieuNguonNuocNhanAsync(Id);
            if (res == true)
            {
                return Ok(new { message = "Dữ liệu: Dữ liệu đã được xóa" });
            }
            else
            {
                return BadRequest(new { message = "Dữ liệu: Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}