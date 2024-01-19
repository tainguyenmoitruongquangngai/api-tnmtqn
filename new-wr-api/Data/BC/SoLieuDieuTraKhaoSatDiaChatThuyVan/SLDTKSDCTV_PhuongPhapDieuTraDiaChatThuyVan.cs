using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class SLDTKSDCTV_PhuongPhapDieuTraDiaChatThuyVan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhuongPhapDieuTraDiaChatThuyVan { get; set; }
        public string? PhuongPhapVienTham { get; set; }
        public string? PhuongPhapDiaVatLy { get; set; }
        public string? PhuongPhapDiaChat { get; set; }
    }
}
