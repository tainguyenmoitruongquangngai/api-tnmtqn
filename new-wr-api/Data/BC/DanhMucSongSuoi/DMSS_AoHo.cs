using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class DMSS_AoHo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHo { get; set; }
        public string? TenHoChua { get; set; }
        public string? Thon_Ban { get; set; }
        public string? Xa_Phuong_ThiTran { get; set; }
        public string? Huyen_ThanhPho { get; set; }
        public string? NguonNuoc { get; set; }
        public string? ThuocHeThongSong { get; set; }
    }
}
