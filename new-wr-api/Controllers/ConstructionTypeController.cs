using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Models;
using new_wr_api.Repositories.ConstructionType;
using System.Data;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConstructionTypeController : ControllerBase
    {
        private readonly IConstructionTypeRepositories _repo;

        public ConstructionTypeController(IConstructionTypeRepositories repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("list")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> GetAllConstructionType()
        {
            try { return Ok(await _repo.GetAllConstructionTypeAsync()); }
            catch { return BadRequest(); }
        }

        [HttpGet]
        [Route("{Id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> GetConstructionById(int Id)
        {
            var res = await _repo.GetConstructionTypeAsync(Id);
            return res == null ? NotFound() : Ok(res);
        }

        [HttpPost]
        [Route("create")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> CreateConstruction(ConstructionTypeModel model)
        {
            var res = await _repo.CreateConstructionTypeAsync(model);
            try { return Ok(res); }
            catch { return BadRequest(); }
        }

        [HttpPost]
        [Route("update/{Id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> UpdateConstruction(int Id, ConstructionTypeModel model)
        {
            var res = await _repo.UpdateConstructionTypeAsync(Id, model);
            try { return Ok(res); }
            catch { return BadRequest(); }
        }

        [HttpGet]
        [Route("delete/{Id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteConstructionById(int Id)
        {
            var res = await _repo.DeleteConstructionTypeAsync(Id);
            try { return Ok(res); }
            catch { return BadRequest(); }
        }
    }
}
