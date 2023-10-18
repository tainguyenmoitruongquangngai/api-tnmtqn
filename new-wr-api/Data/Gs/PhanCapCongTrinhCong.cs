using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class PhanCapCongTrinhCong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhanCapCongTrinhCong { get; set; }
        public int? MaThongTinCongTrinh { get; set; }
        public string? CapCongTrinhCong { get; set; }
    }
}
