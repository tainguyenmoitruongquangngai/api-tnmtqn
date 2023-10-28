using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class PhanLoaiHoChuaTheoMDSD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhanLoaiHoChuaTheoMDSD { get; set; }
        public string? TenLoaiHoChua { get; set; }
        public string? GhiChu { get; set; }
        public virtual ICollection<CongTrinhHoChua>? CongTrinhHoChua { get; set; }
        public virtual ICollection<CongTrinhQuanTracLuuLuongXaDCTT>? CongTrinhQuanTracLuuLuong { get; set; }
        
    }
}
