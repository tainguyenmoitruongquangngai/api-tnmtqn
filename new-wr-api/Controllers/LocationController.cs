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
        [Route("list/commune/{districtId}")]
        public async Task<List<CommuneModel>> GetAllCommunes(string districtId)
        {
            return (await _service.GetAllCommuneAsync(districtId));
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
                return Ok(new { message = "Locations: Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Locations: Lỗi lưu dữ liệu" });
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<Locations>> DeleteLocations(LocationsModel moddel)
        {
            var res = await _service.DeleteLocationAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Locations: Dữ liệu đã được xóa" });
            }
            else
            {
                return Ok(new { message = "Locations: Lỗi xóa dữ liệu" });
            }
        }
    }
}
