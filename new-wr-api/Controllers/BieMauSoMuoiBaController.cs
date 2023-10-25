using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BieuMauSoMuoiBaController : ControllerBase
    {
        private readonly BieuMauMuoiBaService _service;

        public BieuMauSoMuoiBaController(BieuMauMuoiBaService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("danhsach")]
        public async Task<List<BieuMauMuoiBaDto>> GetAll()
        {
            return await _service.GetAllBieuMauMuoiBaAsync();
        }

        [HttpPost]
        [Route("luu")]
        public async Task<ActionResult<BieuMauSoMuoiBa>> Save(BieuMauMuoiBaDto dto)
        {
            var res = await _service.SaveBieuMauMuoiBaAsync(dto);
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
            var res = await _service.DeleteBieuMauMuoiBaAsync(Id);
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