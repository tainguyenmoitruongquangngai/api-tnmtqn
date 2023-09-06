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
    public class AquiferController : ControllerBase
    {
        private readonly AquiferService _service;

        public AquiferController(AquiferService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<AquiferModel>> GetAllAquifer()
        {
            return (await _service.GetAllAquiferAsync());
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<AquiferModel?> GetAquiferById(int Id)
        {
            return await _service.GetAquiferByIdAsync(Id);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<Aquifers>> SaveAquifer(AquiferModel moddel)
        {
            var res = await _service.SaveAquiferAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Tầng chứa nước :Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Tầng chứa nước :Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<Aquifers>> DeleteAquifer(AquiferModel moddel)
        {
            var res = await _service.DeleteAquiferAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Tầng chứa nước :Dữ liệu đã được xóa" });
            }
            else
            {
                return BadRequest(new { message = "Tầng chứa nước :Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}