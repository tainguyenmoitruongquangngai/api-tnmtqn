using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace new_wr_api.Data
{
    public class BieuMauSoMuoi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? LuuVucSong { get; set; }
        public double? TongCongTrinh { get; set; }
        public double?CTTuoiNuocMat{ get; set; }
        public double? CTTuoiNuocDuoiDat { get; set; }
        public double? CTThuyDien { get; set; }
        public double? CTMucDichKhacNuocMat { get; set; }
        public double? CTMucDichKhacNuocDuoiDat { get; set; }
        public string? GhiChu { get; set; }
    }
}
