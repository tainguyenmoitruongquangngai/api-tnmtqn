using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BieuMauSoMuoiBonController : ControllerBase
    {
        private readonly BieuMauMuoiBonService _service;

        public BieuMauSoMuoiBonController(BieuMauMuoiBonService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("danhsach")]
        public async Task<List<BieuMauMuoiBonDto>> GetAll()
        {
            return await _service.GetAllBieuMauMuoiBonAsync();
        }

        [HttpPost]
        [Route("luu")]
        public async Task<ActionResult<BieuMauSoMuoiBon>> Save(BieuMauMuoiBonDto dto)
        {
            var res = await _service.SaveBieuMauMuoiBonAsync(dto);
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
            var res = await _service.DeleteBieuMauMuoiBonAsync(Id);
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