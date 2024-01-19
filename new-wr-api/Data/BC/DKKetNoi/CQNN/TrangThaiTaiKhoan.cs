using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class TrangThaiTaiKhoan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTrangThaiTaiKhoan { get; set; }
        public int? MaCt { get; set; }
        public string? TenTrangThai { get; set; }
        public DateTime? ThoiGianCapNhat { get; set; }

        //tạo  khoá ngoại
        [ForeignKey("MaCt ")]
        public virtual QLC_CongTrinh? QLC_CongTrinh { get; set; }

        public virtual TaiKhoanKetNoi? TaiKhoanKetNoi { get; set; }
    }
}
