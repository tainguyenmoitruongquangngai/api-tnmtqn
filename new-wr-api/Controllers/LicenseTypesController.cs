using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Models;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LicenseTypesController : ControllerBase
    {
        private readonly LicenseTypesService _service;

        public LicenseTypesController(LicenseTypesService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<LicenseTypesModel>> GetAllLicenseTypes()
        {
            return (await _service.GetAllLicenseTypesAsync());
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<LicenseTypesModel?> GetLicenseTypesById(int Id)
        {
            return await _service.GetLicenseTypesByIdAsync(Id);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<LicenseTypes>> SaveLicenseTypes(LicenseTypesModel moddel)
        {
            var res = await _service.SaveLicenseTypesAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Loại giấy phép: Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Loại giấy phép: Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpPost]
        [Route("delete/{Id}")]
        public async Task<ActionResult<LicenseTypes>> DeleteLicenseType(int Id)
        {
            var res = await _service.DeleteLicenseTypesAsync(Id);
            if (res == true)
            {
                return Ok(new { message = "Loại giấy phép: Dữ liệu đã được xóa" });
            }
            else
            {
                return BadRequest(new { message = "Loại giấy phép: Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}
