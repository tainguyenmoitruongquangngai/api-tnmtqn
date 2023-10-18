using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace new_wr_api.Data
{
    public class BieuMauSoMuoiMot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? LuuVucSong { get; set; }
        public double? TongSoCongTrinh { get; set; }
        public double? CongTrinhHoChua { get; set; }
        public double? CongTrinhDapDang { get; set; }
        public double? CongTrinhCong { get; set; }
        public double? CongTrinhTramBom { get; set; }
        public double? CongTrinhKhacNuocMat { get; set; }
        public double? CongTrinhGieng { get; set; }
        public double? CongTrinhKhacNDD { get; set; }
        public string? GhiChu { get; set; }
    }
}
