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
    public class LocationsController : ControllerBase
    {
        private readonly LocationService _service;

        public LocationsController(LocationService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list/distric/{cityId}")]
        public async Task<List<DistrictModel>> GetAllDistricts(string cityId)
        {
            return (await _service.GetAllDistrictAsync(cityId));
        }

        [HttpGet]
        [Route("list/commune")]
        public async Task<List<CommuneModel>> GetAllCommunes()
        {
            return (await _service.GetAllCommuneAsync());
        }

        [HttpGet]
        [Route("list/commune/get-by-distric/{districId}")]
        public async Task<List<CommuneModel>> GetAllCommunesByDistrict(string districId)
        {
            return (await _service.GetAllCommuneByDistrictAsync(districId));
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<LocationsModel?> GetLocationsById(int Id)
        {
            return await _service.GetLocationByIdAsync(Id);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ActionResult<Locations>> SaveLocations(LocationsModel moddel)
        {
            var res = await _service.SaveLocationAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<Locations>> DeleteLocations(int Id)
        {
            var res = await _service.DeleteLocationAsync(Id);
            if (res == true)
            {
                return Ok(new { message = "Dữ liệu đã được xóa" });
            }
            else
            {
                return BadRequest(new { message = "Lỗi xóa dữ liệu", error = true });
            }
        }
    }
}
