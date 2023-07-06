using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Models;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Administrator")]
    public class LicenseController : ControllerBase
    {
        private readonly LicenseService _service;

        public LicenseController(LicenseService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<LicenseModel>> GetAllLicense()
        {
            return (await _service.GetAllLicenseAsync());
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<LicenseModel?> GetLicenseById(int Id)
        {
            return await _service.GetLicenseByIdAsync(Id);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<Licenses>> SaveLicense(LicenseModel moddel)
        {
            var res = await _service.SaveLicenseAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "License: Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "License: Lỗi lưu dữ liệu" });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<Licenses>> DeleteLicense(LicenseModel moddel)
        {
            var res = await _service.DeleteLicenseAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "License: Dữ liệu đã được xóa" });
            }
            else
            {
                return Ok(new { message = "License: Lỗi xóa dữ liệu" });
            }
        }
    }
}
