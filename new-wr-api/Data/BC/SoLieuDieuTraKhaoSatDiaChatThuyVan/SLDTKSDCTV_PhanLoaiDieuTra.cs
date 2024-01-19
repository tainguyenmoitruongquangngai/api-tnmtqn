using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class SLDTKSDCTV_PhanLoaiDieuTra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhanLoaiDieuTra { get; set; }
        public string? Tenloaidieutra { get; set; }
    }
}
