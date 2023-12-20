using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GiamSatSoLieuController : ControllerBase
    {
        private readonly GiamSatService _service;

        public GiamSatSoLieuController(GiamSatService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("danhsach")]
        public async Task<List<GS_SoLieuDto>> GetAll(int? loaict, int? tochuc_canhan, string? tenct)
        {
            return await _service.GetAllAsync(loaict, tochuc_canhan, tenct);
        }
    }
}