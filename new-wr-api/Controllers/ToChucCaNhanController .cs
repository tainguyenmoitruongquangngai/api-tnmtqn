using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("api/to-chuc-ca-nhan")]
    [ApiController]
    [Authorize]
    public class ToChucCaNhanController : ControllerBase
    {
        private readonly ToChucCaNhanService _service;

        public ToChucCaNhanController(ToChucCaNhanService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("danh-sach")]
        public async Task<List<ToChuc_CaNhanDto>> GetAll()
        {
            return (await _service.GetAllAsync());
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<ToChuc_CaNhanDto?> GetById(int Id)
        {
            return await _service.GetByIdAsync(Id);
        }

        [HttpPost]
        [Route("luu")]
        public async Task<ActionResult<ToChuc_CaNhan>> Save(ToChuc_CaNhanDto moddel)
        {
            var res = await _service.SaveAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Doanh nghiệp: Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Doanh nghiệp: Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpGet]
        [Route("xoa/{Id}")]
        public async Task<ActionResult<ToChuc_CaNhan>> Delete(int Id)
        {
            var res = await _service.DeleteAsync(Id);
            if (res == true)
            {
                return Ok(new { message = "Doanh nghiệp: Dữ liệu đã được xóa" });
            }
            else
            {
                return BadRequest(new { message = "Doanh nghiệp: Lỗi xóa dữ liệu" });
            }
        }
    }
}
