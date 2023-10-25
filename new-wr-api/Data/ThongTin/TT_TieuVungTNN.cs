using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class TT_TieuVungTNN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTieuVung { get; set; }
        public int? MaHuyen { get; set; }
        public int? MaXa { get; set; }
        public string? TenTieuVung { get; set; }
    }
}
