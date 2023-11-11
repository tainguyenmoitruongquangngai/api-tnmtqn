using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class KQCGHTHGPKTSDN_ThongTinGiayPhepKTSDN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaThongTinGiayPhepKTSDN { get; set; }
        public int? MaCongTrinh { get; set; }
        public string? SoGiayPhepKTSDN { get; set; }
        public string? TenGiayPhepKTSDN { get; set; }
    }
}
