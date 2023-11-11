using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class SLDTKSDCTV_TieuVungQuyHoach
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTieuVungQuyHoach { get; set; }
        public string? TieuVungQuyHoach { get; set; }
    }
}
