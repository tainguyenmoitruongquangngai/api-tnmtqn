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
    public class LicenseFeeController : ControllerBase
    {
        private readonly LicenseFeeService _service;

        public LicenseFeeController(LicenseFeeService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<LicenseFeeModel>> GetAllLicenseFee()
        {
            return (await _service.GetAllLicenseFeeAsync());
        }

        [HttpGet]
        [Route("list/{licensingAuthorities}")]
        public async Task<List<LicenseFeeModel>> GetLicenseFeeByLicensingAuthorities(string licensingAuthorities)
        {
            return (await _service.GetLicenseFeeByLicensingAuthoritiesAsync(licensingAuthorities));
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<LicenseFeeModel?> GetLicenseFeeById(int Id)
        {
            return await _service.GetLicenseFeeByIdAsync(Id);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<LicenseFees>> SaveLicenseFee(LicenseFeeModel moddel)
        {
            var res = await _service.SaveLicenseFeeAsync(moddel);
            if (res > 0)
            {
                return Ok(new { message = "Tiền cấp quyền: Dữ liệu đã được lưu", id = res });
            }
            else
            {
                return BadRequest(new { message = "Tiền cấp quyền: Lỗi lưu dữ liệu" });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<LicenseFees>> DeleteLicenseFee(LicenseFeeModel moddel)
        {
            var res = await _service.DeleteLicenseFeeAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Tiền cấp quyền: Dữ liệu đã được xóa" });
            }
            else
            {
                return Ok(new { message = "Tiền cấp quyền: Lỗi xóa dữ liệu" });
            }
        }
    }
}
