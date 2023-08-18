using Microsoft.AspNetCore.Mvc;
using new_wr_api.Models.Files;
using System;
using System.IO;
using System.Threading.Tasks;

namespace new_wr_api.Controllers
{
    [ApiController]
    [Route("api")]
    public class FileController : ControllerBase
    {
        private readonly string _uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "FileUploads");

        public FileController()
        {
            if (!Directory.Exists(_uploadDirectory))
            {
                Directory.CreateDirectory(_uploadDirectory);
            }
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile([FromForm] UploadModel uploadFile)
        {
            try
            {
                if (uploadFile.File != null && uploadFile.File.Length > 0 && !string.IsNullOrEmpty(uploadFile.FilePath))
                {
                    var fileDirectory = Path.Combine(_uploadDirectory, uploadFile.FilePath);
                    if (!Directory.Exists(fileDirectory))
                    {
                        Directory.CreateDirectory(fileDirectory);
                    }

                    var fileName = uploadFile.FileName;
                    var filePath = Path.Combine(fileDirectory, fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await uploadFile.File.CopyToAsync(stream);
                    }

                    return Ok(new { FilePath = filePath });
                }
                else
                {
                    return BadRequest("No file uploaded");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("getfile")]
        public IActionResult GetFile([FromQuery] GetModel getFile)
        {
            var filePath = Path.Combine($"{_uploadDirectory}/{getFile.FilePath}", getFile.FileName);
            if (System.IO.File.Exists(filePath))
            {
                var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                return File(fileStream, "application/octet-stream");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
