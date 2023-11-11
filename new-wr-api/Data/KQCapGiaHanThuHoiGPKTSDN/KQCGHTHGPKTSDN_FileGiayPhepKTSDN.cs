using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class KQCGHTHGPKTSDN_FileGiayPhepKTSDN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaFileGiayPhepKTSDN { get; set; }
        public int? MaThongTinGiayPhepKTSDN { get; set; }
        public string? FileScanGiayPhepKTSDN { get; set; }
        public string? FileScanGiayToLienQuanCuaGiayPhepKTSDN { get; set; }
    }
}
