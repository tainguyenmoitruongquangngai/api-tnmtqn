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
    public class NN_MatCatSongSuoiController : ControllerBase
    {
        private readonly NN_MatCatSongSuoiService _service;

        public NN_MatCatSongSuoiController(NN_MatCatSongSuoiService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("danh-sach")]
        public async Task<List<NN_MatCatSongSuoiDto>> GetAll()
        {
            return await _service.GetAllMatCatSongSuoiAsync();
        }

        [HttpPost]
        [Route("luu")]
        public async Task<ActionResult<NN_MatCatSongSuoiDto>> Save(NN_MatCatSongSuoiDto moddel)
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
        public async Task<ActionResult<NN_MatCatSongSuoiDto>> Delete(int Id)
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
