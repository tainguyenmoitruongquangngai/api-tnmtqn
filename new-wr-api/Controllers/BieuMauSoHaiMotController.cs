using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BieuMauSoHaiMotController : ControllerBase
    {
        private readonly BieuMauHaiMotService _service;

        public BieuMauSoHaiMotController(BieuMauHaiMotService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("danhsach")]
        public async Task<List<BieuMauHaiMotDto>> GetAll()
        {
            return await _service.GetAllBieuMauHaiMotAsync();
        }

        [HttpPost]
        [Route("luu")]
        public async Task<ActionResult<BieuMauSoHaiMot>> Save(BieuMauHaiMotDto dto)
        {
            var res = await _service.SaveBieuMauHaiMotAsync(dto);
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
            var res = await _service.DeleteBieuMauHaiMotAsync(Id);
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