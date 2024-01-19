using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class TT_ThongTinTieuVung
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaThongTin { get; set; }
        public int MaTieuVung { get; set; }
        public int? MaHuyen { get; set; }
        public int? MaXa { get; set; }
        public double? DienTichTieuVung { get; set; }
        public double? LuuLuongNuocTrungBinh { get; set; }
        public double? DanSo { get; set; }
        public double? LoaiTaiNguyenNuoc { get; set; }
    }
}
