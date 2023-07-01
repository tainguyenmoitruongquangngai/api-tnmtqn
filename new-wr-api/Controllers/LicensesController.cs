using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Models;
using new_wr_api.Repositories.License;
using System.Data;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Administrator")]
    public class LicenseController : ControllerBase
    {
        private readonly ILicenseRepositories _repo;

        public LicenseController(ILicenseRepositories repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> GetAllLicense()
        {
            try { return Ok(await _repo.GetAllLicenseAsync()); }
            catch { return BadRequest(); }
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetLicenseById(int Id)
        {
            var res = await _repo.GetLicenseAsync(Id);
            return res == null ? NotFound() : Ok(res);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateLicense(LicenseModel model)
        {
            var res = await _repo.CreateLicenseAsync(model);
            try { return Ok(res); }
            catch { return BadRequest(); }
        }

        [HttpPost]
        [Route("update/{Id}")]
        public async Task<IActionResult> UpdateLicense(int Id, LicenseModel model)
        {
            var res = await _repo.UpdateLicenseAsync(Id, model);
            try { return Ok(res); }
            catch { return BadRequest(); }
        }

        [HttpGet]
        [Route("delete/{Id}")]
        public async Task<IActionResult> DeleteLicenseById(int Id)
        {
            var res = await _repo.DeleteLicenseAsync(Id);
            try { return Ok(res); }
            catch { return BadRequest(); }
        }
    }
}
