using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class ChuyenVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaChuyenVien { get; set; }
        public int? MaThongTinCQNN { get; set; }
        public string? TenChuyenVien { get; set; }
        public string? SoDienThoai { get; set; }
        public string? Email { get; set; }

        //tạo  khoá ngoại
        [ForeignKey("MaThongTinCQNN ")]
        public virtual ThongTinCQNN? ThongTinCQNN { get; set; }
    }
}
