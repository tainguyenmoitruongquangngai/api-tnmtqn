using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace new_wr_api.Data
{
    public class VHHC_HoChua_ThongSoKT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? TenHoChua { get; set; }
        public string? ThuocLVS { get; set; }
        public double? FLv { get; set; }
        public double? XTbNam { get; set; }
        public double? QoTbNam { get; set; }
        public double? P002 { get; set; }
        public double? P01 { get; set; }
        public double? P02 { get; set; }
        public double? P05 { get; set; }
        public double? MNDBT { get; set; }
        public double? MNC { get; set; }
        public double? MNMaxP002 { get; set; }
        public double? MNMaxP01 { get; set; }
        public double? MNMaxP02 { get; set; }
        public double? MNMaxP05 { get; set; }
        public double? WToanBo { get; set; }
        public double? WHuuIch { get; set; }
        public double? WNam { get; set; }
        public double? WNhieuNam { get; set; }
        public double? WChet { get; set; }
        public double? QDamBao { get; set; }
        public double? QMin { get; set; }
        public double? QMax { get; set; }
        public string? GhiChu { get; set; }
        public DateTime? ThoiGianTao { get; set; }
        public string? TaiKhoanTao { get; set; }
        public DateTime? ThoiGianSua { get; set; }
        public string? TaiKhoanSua { get; set; }
        public bool? DaXoa { get; set; }
    }
}
