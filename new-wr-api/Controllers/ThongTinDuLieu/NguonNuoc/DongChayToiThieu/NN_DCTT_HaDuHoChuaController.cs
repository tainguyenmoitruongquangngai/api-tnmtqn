﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Models;
using new_wr_api.Service;

namespace new_wr_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NN_DCTT_HaDuHoChuaController : ControllerBase
    {
        private readonly NN_DCTT_HaDuHoChuaService _service;

        public NN_DCTT_HaDuHoChuaController(NN_DCTT_HaDuHoChuaService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("danh-sach")]
        public async Task<List<NN_DCTT_HaDuHoChuaDto>> GetAll()
        {
            return await _service.GetAllDCTT_HaDuHoChuaAsync();
        }

        [HttpPost]
        [Route("luu")]
        public async Task<ActionResult<NN_DCTT_HaDuHoChuaDto>> Save(NN_DCTT_HaDuHoChuaDto moddel)
        {
            var res = await _service.SaveAsync(moddel);
            if (res == true)
            {
                return Ok(new { message = "Dữ liệu đã được lưu" });
            }
            else
            {
                return BadRequest(new { message = "Lỗi lưu dữ liệu", error = true });
            }
        }

        [HttpGet]
        [Route("xoa/{Id}")]
        public async Task<ActionResult<NN_DCTT_HaDuHoChuaDto>> Delete(int Id)
        {
            var res = await _service.DeleteAsync(Id);
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
