using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class TLN_NuocDuoiDat_SoLuong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? IdTangChuaNuoc { get; set; }
        public int? SoLuongGieng { get; set; }
        public double? HmaxKyTruoc { get; set; }
        public double? HmaxBaoCao { get; set; }
        public double? HTBKyTruoc { get; set; }
        public double? HTBBaoCao { get; set; }
        public double? HminKyTruoc { get; set; }
        public double? HminBaoCao { get; set; }
        public string? GhiChu { get; set; }
        public bool? DaXoa { get; set; }

        [ForeignKey("IdTangChuaNuoc")]
        public virtual TangChuaNuoc? TangChuaNuoc { get; set; }
    }
}
