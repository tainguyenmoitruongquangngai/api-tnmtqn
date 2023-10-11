using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace new_wr_api.Data
{
    public class TLN_NuocMat_SoLuong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? IdSong { get; set; }
        public string? ChayRa { get; set; }
        public double? ChieuDai { get; set; }
        public double? XDauSong { get; set; }
        public double? YDauSong { get; set; }
        public int? IdXaDauSong { get; set; }
        public int? IdHuyenDauSong { get; set; }
        public double? XCuoiSong { get; set; }
        public double? YCuoiSong { get; set; }
        public int? IdXaCuoiSong { get; set; }
        public int? IdHuyenCuoiSong { get; set; }
    }
}
