using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Models;
using new_wr_api.Repositories.Construction;
using System.Data;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Administrator")]
    public class ConstructionController : ControllerBase
    {
        private readonly IConstructionRepositories _repo;

        public ConstructionController(IConstructionRepositories repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> GetAllConstruction()
        {
            try { return Ok(await _repo.GetAllConstructionAsync()); }
            catch { return BadRequest(); }
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetConstructionById(int Id)
        {
            var res = await _repo.GetConstructionAsync(Id);
            return res == null ? NotFound() : Ok(res);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateConstruction(ConstructionModel model)
        {
            var res = await _repo.CreateConstructionAsync(model);
            try { return Ok(res); }
            catch { return BadRequest(); }
        }

        [HttpPost]
        [Route("update/{Id}")]
        public async Task<IActionResult> UpdateConstruction(int Id, ConstructionModel model)
        {
            var res = await _repo.UpdateConstructionAsync(Id, model);
            try { return Ok(res); }
            catch { return BadRequest(); }
        }

        [HttpGet]
        [Route("delete/{Id}")]
        public async Task<IActionResult> DeleteConstructionById(int Id)
        {
            var res = await _repo.DeleteConstructionAsync(Id);
            try { return Ok(res); }
            catch { return BadRequest(); }
        }
    }
}
