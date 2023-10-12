using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace new_wr_api.Data
{
    public class TangChuaNuoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? TenTCN { get; set; }
        public string? KyHieuTCN { get; set; }
        public DateTime? ThoiGianTao { get; set; }
        public string? TaiKhoanTao { get; set; }
        public DateTime? ThoiGianSua { get; set; }
        public string? TaiKhoanSua { get; set; }
        public bool? DaXoa { get; set; }

        public virtual ICollection<CT_ThongTin>? CongTrinh { get; set; }

    }
}
