using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Data.BC.KNTiepNhanNuocThai.KNTNNTSong;
using new_wr_api.Dto;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PhanDoanSongController : ControllerBase
    {
        private readonly PhanDoanSongService _service;

        public PhanDoanSongController(PhanDoanSongService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("danhsach")]
        public async Task<List<PhanDoanSongDto>> GetAll()
        {
            return await _service.GetAllPhanDoanSongAsync();
        }

        [HttpPost]
        [Route("luu")]
        public async Task<ActionResult<PhanDoanSong>> Save(PhanDoanSongDto dto)
        {
            var res = await _service.SavePhanDoanSongAsync(dto);
            if (res == true)
            {
                return Ok(new { message = "Phân đoạn sông: Dữ liệu đã được lưu", id = res });
            }
            else
            {
                return BadRequest(new { message = "Phân đoạn sông: Lỗi lưu dữ liệu", error = true });
            }
        }


        [HttpGet]
        [Route("xoa/{Id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var res = await _service.DeletePhanDoanSongAsync(Id);
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