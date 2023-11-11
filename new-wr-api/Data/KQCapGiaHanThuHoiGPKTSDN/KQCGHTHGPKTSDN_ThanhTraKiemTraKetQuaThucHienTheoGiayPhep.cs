using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class KQCGHTHGPKTSDN_ThanhTraKiemTraKetQuaThucHienTheoGiayPhep
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaThanhTra_KiemTraKetQuaThucHienTheoGiayPhepKTSDN { get; set; }
        public int? MaThongTinGiayPhepKTSDN { get; set; }
        public string? MaCongTrinh { get; set; }
        public string? HoSoKetQuaThanhTra_KiemTr { get; set; }
    }
}
