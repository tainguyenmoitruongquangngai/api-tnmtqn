using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class HSKTCT_ToChucThucHienQuanTrac
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaToChucThucHien { get; set; }
        public string? TenToChucThucHien { get; set; }
    }
}
