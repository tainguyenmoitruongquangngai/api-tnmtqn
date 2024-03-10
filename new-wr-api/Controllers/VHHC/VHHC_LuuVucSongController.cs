using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Models;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VHHC_LuuVucSongController : ControllerBase
    {
        private readonly VHHC_LuuVucSongService _service;

        public VHHC_LuuVucSongController(VHHC_LuuVucSongService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("danh-sach")]
        public async Task<List<VHHC_LuuVucSongDto>> GetAll()
        {
            return await _service.GetAllVHHC_LuuVucSongAsync();
        }

        [HttpPost]
        [Route("luu")]
        public async Task<ActionResult<VHHC_LuuVucSongDto>> Save(VHHC_LuuVucSongDto moddel)
        {
            var res = await _service.SaveAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpGet]
        [Route("xoa/{Id}")]
        public async Task<ActionResult<VHHC_LuuVucSongDto>> Delete(int Id)
        {
            var res = await _service.DeleteAsync(Id);
            if (res == true)
            {
                return Ok(new { message = "Dữ liệu đã được xóa" });
            }
            else
            {
                return BadRequest(new { message = "Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}
