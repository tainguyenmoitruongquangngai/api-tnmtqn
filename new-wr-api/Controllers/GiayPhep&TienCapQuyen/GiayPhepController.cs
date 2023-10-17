using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("api/giay-phep")]
    [ApiController]
    [Authorize]
    public class GiayPhepController : ControllerBase
    {
        private readonly GP_ThongTinService _service;

        public GiayPhepController(GP_ThongTinService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("danh-sach")]
        public async Task<List<GP_ThongTinDto>> GetAllData(string? sogp, int? tochuc_canhan, int? congtrinh, int? loaigp, int? loaict, string? hieuluc)
        {
            return await _service.GetAllAsync(sogp, tochuc_canhan, congtrinh, loaigp, loaict, hieuluc);
        }

        [HttpGet]
        [Route("dem-theo-co-quan-cp")]
        public async Task<CountDataDto> CountFollowLicensingAuthorities()
        {
            return await _service.CountFollowLicensingAuthoritiesAsync();
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<GP_ThongTinDto?> GetOneData(int Id)
        {
            return await _service.GetByIdAsync(Id);
        }

        [HttpPost]
        [Route("luu")]
        public async Task<ActionResult<GP_ThongTin>> SaveConstruction(GP_ThongTinDto dto)
        {
            var res = await _service.SaveAsync(dto);
            if (res > 0)
            {
                return Ok(new { message = "Giấy phép: Dữ liệu đã được lưu", id = res });
            }
            else
            {
                return BadRequest(new { message = "Giấy phép: Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpPost]
        [Route("xoa/{Id}")]
        public async Task<ActionResult<GP_ThongTin>> DeleteConstruction(int Id)
        {
            var res = await _service.DeleteAsync(Id);
            if (res == true)
            {
                return Ok(new { message = "Giấy phép: Dữ liệu đã được xóa" });
            }
            else
            {
                return BadRequest(new { message = "Giấy phép: Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}
