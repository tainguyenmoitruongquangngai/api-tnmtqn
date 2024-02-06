using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DonViDoController : ControllerBase
    {
        private readonly DonViDoService _service;

        public DonViDoController(DonViDoService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("danhsach")]
        public async Task<List<DonViDo>> GetAll()
        {
            return await _service.GetAllAsync();
        }
    }
}