using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Models;
using new_wr_api.Repositories.Constructions;
using System.Data;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConstructionsController : ControllerBase
    {
        private readonly IConstructionsRepositories _repo;

        public ConstructionsController(IConstructionsRepositories repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("list")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> GetAllConstructions()
        {
            try { return Ok(await _repo.GetAllConstructionsAsync()); }
            catch { return BadRequest(); }
        }

        [HttpGet]
        [Route("{Id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> GetConstructionById(int Id)
        {
            var res = await _repo.GetConstructionAsync(Id);
            return res == null ? NotFound() : Ok(res);
        }

        [HttpPost]
        [Route("create")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> CreateConstruction(ConstructionsModel model)
        {
            var res = await _repo.CreateConstructionAsync(model);
            try { return Ok(res); }
            catch { return BadRequest(); }
        }

        [HttpPost]
        [Route("update/{Id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> UpdateConstruction(int Id, ConstructionsModel model)
        {
            var res = await _repo.UpdateConstructionAsync(Id, model);
            try { return Ok(res); }
            catch { return BadRequest(); }
        }

        [HttpGet]
        [Route("delete/{Id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteConstructionById(int Id)
        {
            var res = await _repo.DeleteConstructionAsync(Id);
            try { return Ok(res); }
            catch { return BadRequest(); }
        }
    }
}
