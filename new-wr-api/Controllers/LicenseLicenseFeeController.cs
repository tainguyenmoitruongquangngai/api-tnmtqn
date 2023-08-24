using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Models;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Administrator")]
    public class LicenseLicenseFeeController : ControllerBase
    {
        private readonly LicenseLicenseFeeService _service;
        private readonly DatabaseContext _context;

        public LicenseLicenseFeeController(LicenseLicenseFeeService service, DatabaseContext context)
        {
            _service = service;
            _context = context;
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<LicenseLicenseFee>> SaveLicenseLicenseFee(LicenseLicenseFeeModel moddel)
        {
            var lic = await _context.Licenses!.FirstOrDefaultAsync(l => l.Id == moddel.LicenseId);
            var licFee = await _context.LicenseFees!.FirstOrDefaultAsync(l => l.Id == moddel.LicenseFeeId);

            if (lic != null && licFee != null)
            {
                var res = await _service.SaveLicenseLicenseFeeAsync(moddel);
                if (res == true)
                {
                    return Ok(new { message = "LicenseLicenseFee: Dữ liệu đã được lưu" });
                }
                else
                {
                    return BadRequest(new { message = "LicenseLicenseFee: Lỗi lưu dữ liệu", error = true });
                }
            }
            else
            {
                if (licFee == null)
                {
                    return BadRequest(new { message = "Tiền cấp quyền không tồn tại", error = true });
                }
                else
                {
                    return BadRequest(new { message = "Giấy phép không tồn tại", error = true });
                }
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<LicenseLicenseFee>> DeleteLicenseLicenseFee(LicenseLicenseFeeModel moddel)
        {
            var res = await _service.DeleteLicenseLicenseFeeAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "LicenseLicenseFee: Dữ liệu đã được xóa" });
            }
            else
            {
                return Ok(new { message = "LicenseLicenseFee: Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}
