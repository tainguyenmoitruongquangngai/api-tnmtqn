using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class HSKTCT_LoaiHSKTCongTrinh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaLoaiHoSoKTCongTrinh { get; set; }
        public int? MaCongTrinh { get; set; }
        public int? MaToChucThucHien { get; set; }
        public string? MaTaiLieu { get; set; }
        public string? MaFilePDF { get; set; }
        public string? TenLoaiHoSo { get; set; }
    }
}
