using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BieuMauSoMuoiSauController : ControllerBase
    {
        private readonly BieuMauMuoiSauService _service;

        public BieuMauSoMuoiSauController(BieuMauMuoiSauService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("danhsach")]
        public async Task<List<BieuMauMuoiSauDto>> GetAll()
        {
            return await _service.GetAllBieuMauMuoiSauAsync();
        }

        [HttpPost]
        [Route("luu")]
        public async Task<ActionResult<BieuMauSoMuoiSau>> Save(BieuMauMuoiSauDto dto)
        {
            var res = await _service.SaveBieuMauMuoiSauAsync(dto);
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
            var res = await _service.DeleteBieuMauMuoiSauAsync(Id);
            if (res == true)
            {
                return Ok(new { message = "Biểu mẫu: Dữ liệu đã được xóa" });
            }
            else
            {
                return BadRequest(new { message = "Biểu mẫu: Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}