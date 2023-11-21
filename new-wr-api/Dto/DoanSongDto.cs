using new_wr_api.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Dto
{
    public class DoanSongDto
    {
        public int? Id { get; set; }
        public string? TenDoanSong { get; set; }
        public int? IdLVSong { get; set; }
        public int? IdSong { get; set; }
        public double? ChieuDai { get; set; }
        public double? DienTichLV { get; set; }
        public string? DiaGioiHanhChinh { get; set; }
        public string? MucDichSuDung { get; set; }
        public double? XDau { get; set; }
        public double? YDau { get; set; }
        public double? XCuoi { get; set; }
        public double? YCuoi { get; set; }
        public double? Qs { get; set; }
        public  ThongSoLtdDto? ThongSoLtd { get; set; }
        public  SongDto? Song { get; set; }
    }
    
}
