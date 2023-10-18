using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class ThongSoKyThuatCongTrinh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaThongSoKyThuatCongTrinhTramBom { get; set; }
        public int? MaThongTinCongTrinhTramBom { get; set; }
        public string? MaThongSoVanHanhThucTe { get; set; }
        public string? LuuLuongThietKe { get; set; }
        public string? LuuLuongThucTe { get; set; }
        public DateTime? DienTichTuoiThietKe { get; set; }
        public string? DienTichTuoiThucTe{ get; set; }
        public DateTime? LuuLuongLayNuoc { get; set; }
        public string? TongLuongNuocKhaiThac { get; set; }
    }
}
