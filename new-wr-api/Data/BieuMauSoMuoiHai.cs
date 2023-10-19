using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace new_wr_api.Data
{
    public class BieuMauSoMuoiHai
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? LuuVucSong { get; set; }
        public double? TongSoCongTrinh { get; set; }
        public double? TuoiNguonNuocMat { get; set; }
        public double? TuoiNguonNuocDuoiDat { get; set; }
        public double? KhaiThacThuyDien { get; set; }
        public double? MucDichKhacNguonNuocMat { get; set; }
        public double? MucDichKhacNguonNuocDD { get; set; }
        public string? GhiChu { get; set; }
    }
}
