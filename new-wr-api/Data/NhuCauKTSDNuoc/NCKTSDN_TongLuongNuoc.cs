using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class NCKTSDN_TongLuongNuoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTongLuongNuoc { get; set; }
        public int? MaLoaiTaiNguyenNuoc { get; set; }
        public string? TieuVungLuuVuc { get; set; }
        public double? TongLuongMua { get; set; }
        public double? LuuLuongDongChayMat { get; set; }
        public double? TruLuongTiemNangNuocNgam { get; set; }
        public double? ModulDongChayNgam { get; set; }
    }
}
