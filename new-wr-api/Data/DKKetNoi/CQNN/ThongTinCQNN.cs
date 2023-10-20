using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class ThongTinCQNN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaThongTinCQNN { get; set; }
        public string? TenCQNN { get; set; }
        public string? DiaChiCQNN { get; set; }

        public virtual ChuyenVien? ChuyenVien { get; set; }
    }
}
