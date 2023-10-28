using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class DuLieuQuanTracCuaCTKTNDD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaDuLieuQuanTracCuaCTKTNDD { get; set; }
        public int? MaThongTinCongTrinh { get; set; }
        public double? LuuLuongKTGiengKhoan { get; set; }
        public double? MucNuocTrongGiengKT { get; set; }
        public double? MucNuocTrongGiengQT { get; set; }
        public string? TrangThaiVH { get; set; }


        //tạo  khoá ngoại
        [ForeignKey("MaThongTinCongTrinh ")]
        public virtual QLC_CongTrinh? QLC_CongTrinh { get; set; }
    }
}
