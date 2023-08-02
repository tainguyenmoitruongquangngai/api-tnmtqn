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
    public class BusinessController : ControllerBase
    {
        private readonly BusinessService _service;

        public BusinessController(BusinessService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<BusinessModel>> GetAllBusiness()
        {
            return (await _service.GetAllBusinessAsync());
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<BusinessModel?> GetBusinessById(int Id)
        {
            return await _service.GetBusinessByIdAsync(Id);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<Business>> SaveBusiness(BusinessModel moddel)
        {
            var res = await _service.SaveBusinessAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Business: Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Business: Lỗi lưu dữ liệu" });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<Business>> DeleteBusiness(BusinessModel moddel)
        {
            var res = await _service.DeleteBusinessAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Business: Dữ liệu đã được xóa" });
            }
            else
            {
                return Ok(new { message = "Business: Lỗi xóa dữ liệu" });
            }
        }
    }
}
