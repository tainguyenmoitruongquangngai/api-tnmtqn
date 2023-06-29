using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Models;
using new_wr_api.Repositories.Licenses;
using System.Data;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admintrator")]
    public class LicensesController : ControllerBase
    {
        private readonly ILicensesRepositories _repo;

        public LicensesController(ILicensesRepositories repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> GetAllLicenses()
        {
            try { return Ok(await _repo.GetAllLicensesAsync()); }
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
        public async Task<IActionResult> CreateLicense(LicensesModel model)
        {
            var res = await _repo.CreateLicenseAsync(model);
            try { return Ok(res); }
            catch { return BadRequest(); }
        }

        [HttpPost]
        [Route("update/{Id}")]
        public async Task<IActionResult> UpdateLicense(int Id, LicensesModel model)
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
