using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class PhuongPhapTinhMua
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhuongPhapTinhMua { get; set; }
        public string? TenPhuongPhap { get; set; }
        public string? GhiChu { get; set; }

        public virtual SoLieuMua? SoLieuMua { get; set; }
        public virtual TongLuongMua? TongLuongMua { get; set; }
    }
}
