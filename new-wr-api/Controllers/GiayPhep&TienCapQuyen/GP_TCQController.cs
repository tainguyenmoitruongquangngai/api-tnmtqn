using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GP_TCQController : ControllerBase
    {
        private readonly GP_TCQService _service;
        private readonly DatabaseContext _context;

        public GP_TCQController(GP_TCQService service, DatabaseContext context)
        {
            _service = service;
            _context = context;
        }

        [HttpPost]
        [Route("luu")]
        public async Task<ActionResult<GP_TCQ>> SaveGP_TCQ(GP_TCQDto dto)
        {
            var res = await _service.SaveAsync(dto);
            if (res == true)
            {
                return Ok(new { message = "GP_TCQ: Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "GP_TCQ: Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpPost]
        [Route("xoa")]
        public async Task<ActionResult<GP_TCQ>> DeleteGP_TCQ(GP_TCQDto dto)
        {
            var res = await _service.DeleteAsync(dto);
            if (res == true)
            {
                return Ok(new { message = "GP_TCQ: Dữ liệu đã được xóa" });
            }
            else
            {
                return Ok(new { message = "GP_TCQ: Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}
