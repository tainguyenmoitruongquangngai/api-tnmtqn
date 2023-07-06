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
        public async Task<ActionResult<Licenses>> GetLicenseById(int Id)
        {
            var res = await _service.GetLicenseByIdAsync(Id);
            if (res == null)
            {
                return NotFound(new { message = "License not found" });
            }
            return Ok(new
            {
                user = res
            });
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<Licenses>> SaveLicense(LicenseModel moddel)
        {
            var res = await _service.SaveLicenseAsync(moddel);
            if (res.Succeeded)
            {
                return Ok(new
                {
                    message = res
                });
            }
            return BadRequest(new
            {
                message = res
            });
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<Licenses>> DeleteLicense(LicenseModel moddel)
        {
            var res = await _service.DeleteLicenseAsync(moddel);
            if (res.Succeeded)
            {
                return Ok(new
                {
                    message = res
                });
            }
            return BadRequest(new
            {
                message = res
            });
        }
    }
}
