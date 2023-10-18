using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class ThongSoVanHanhThucTe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaThongSoVanHanhThucTe { get; set; }
        public int? MaThongTinCongTrinh { get; set; }
        public string? LuuLuongKhaiThacThucTe { get; set; }
        public string? LuuLuongKhaiThacYeuCau { get; set; }
        public string? LuuLuongKhaiThacChenhLech { get; set; }
    }
}
