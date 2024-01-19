using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class HSKTCT_FilePDFHSKTCongTrinh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaFilePDFHoSoKyThuatCongTrinh { get; set; }
        public string? CacTaiLieuHsktTramDuoiDangFilePDF { get; set; }
    }
}
