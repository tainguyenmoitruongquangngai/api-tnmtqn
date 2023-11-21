using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class DoanSongController : ControllerBase
    {
        private readonly DoanSongService _service;

        public DoanSongController(DoanSongService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("danh-sach")]
        public async Task<List<DoanSongDto>> GetAllData(string? MucPLCLNuoc)
        {
            return await _service.GetAllAsync(MucPLCLNuoc);
        }
    }
}
