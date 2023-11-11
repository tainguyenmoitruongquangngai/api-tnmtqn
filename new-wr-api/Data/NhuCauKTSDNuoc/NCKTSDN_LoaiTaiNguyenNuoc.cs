using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class NCKTSDN_LoaiTaiNguyenNuoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaLoaiTaiNguyenNuoc { get; set; }
        public int? MaKhaNangDapUngNguonNuoc { get; set; }
        public string? LuuVuc { get; set; }
        public double? TongLuongNuoc { get; set; }
        public double? TongNhuCauNuoc { get; set; }
        public double? TiLeSoVoiNhuCau { get; set; }
    }
}
