using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class ThongTinCongTrinh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaThongTinCongTrinh{ get; set; }
        public int? TenCongTrinhKhaiThac{ get; set; }
        public string? DiaDiemCongTrinh_Xa { get; set; }
        public string? DiaDiemCongTrinh_Huyen { get; set; }
        public string? SoCongTrinh{ get; set; }
    }
}
