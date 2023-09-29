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
        public async Task<List<LicenseModel>> GetAllLicense(string? LicenseNumber, string? LicensingAuthorities, int? LicenseTypeId, string? LicenseValidity, int? BusinessId, int? ConstructionId, int? ConstructionTypeId, int? DistrictId, int? CommuneId, int? SubBasinId, int PageIndex, int PageSize)
        {
            return (await _service.GetAllLicenseAsync(LicenseNumber, LicensingAuthorities, LicenseTypeId, LicenseValidity, BusinessId, ConstructionId, ConstructionTypeId, DistrictId, CommuneId, SubBasinId, PageIndex, PageSize));
        }

        [HttpGet]
        [Route("list-for-count")]
        public async Task<List<LicenseModel>?> GetAllLicenseForCount()
        {
            return (await _service.GetLicenseForCountAsync());
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
            if (res != 0)
            {
                return Ok(new { message = "Giấy phép: Dữ liệu đã được lưu", id = res });
            }
            else
            {
                return BadRequest(new { message = "Giấy phép: Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<Licenses>> DeleteLicense(int Id)
        {
            var res = await _service.DeleteLicenseAsync(Id);
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
